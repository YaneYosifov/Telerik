namespace VisualStudioWPFTests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using ArtOfTest.WebAii.Controls.Xaml.Wpf;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.TestTemplates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Microsoft.Win32;

    /// <summary>
    /// Summary description for VisualStudioProject
    /// </summary>
    [TestClass]
    public class VisualStudioProject : BaseWpfTest
    {

        #region [Setup / TearDown]

        private TestContext testContextInstance = null;
        /// <summary>
        ///Gets or sets the VS test context which provides
        ///information about and functionality for the
        ///current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }


        //Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
        }


        // Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            #region WebAii Initialization

            // Initializes WebAii manager to be used by the test case.
            // If a WebAii configuration section exists, settings will be
            // loaded from it. Otherwise, will create a default settings
            // object with system defaults.
            //
            // Note: We are passing in a delegate to the VisualStudio
            // testContext.WriteLine() method in addition to the Visual Studio
            // TestLogs directory as our log location. This way any logging
            // done from WebAii (i.e. Manager.Log.WriteLine()) is
            // automatically logged to the VisualStudio test log and
            // the WebAii log file is placed in the same location as VS logs.
            //
            // If you do not care about unifying the log, then you can simply
            // initialize the test by calling Initialize() with no parameters;
            // that will cause the log location to be picked up from the config
            // file if it exists or will use the default system settings (C:\WebAiiLog\)
            // You can also use Initialize(LogLocation) to set a specific log
            // location for this test.

            Initialize(this.TestContext.TestLogsDir, new TestContextWriteLine(this.TestContext.WriteLine));

            // If you need to override any other settings coming from the
            // config section you can comment the 'Initialize' line above and instead
            // use the following:

            /*

            // This will get a new Settings object. If a configuration
            // section exists, then settings from that section will be
            // loaded

            Settings settings = GetSettings();

            // Override the settings you want. For example:
            settings.WaitCheckInterval = 10000;

            // Now call Initialize again with your updated settings object
            Initialize(settings, new TestContextWriteLine(this.TestContext.WriteLine));

            */

            // Set the current test method. This is needed for WebAii to discover
            // its custom TestAttributes set on methods and classes.
            // This method should always exist in [TestInitialize()] method.
            SetTestMethod(this, (string)TestContext.Properties["TestName"]);

            #endregion

            //
            // Place any additional initialization here
            //

        }

        // Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {

            //
            // Place any additional cleanup here
            //

            #region WebAii CleanUp

            // Shuts down WebAii manager and closes all applications currently running
            // after each test.
            this.CleanUp();

            #endregion
        }

        //Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            // This will shut down all applications
            ShutDown();
        }

        #endregion

        [TestMethod]
        public void CreateNewProject()
        {
            string vsExecutable = this.GetVisualStudioExecutable();
            var application = Manager.LaunchNewApplication(new System.Diagnostics.ProcessStartInfo(vsExecutable));

            application.MainWindow.Find.ByTextContent("New Project...").User.Click();
            Thread.Sleep(2000);
            Manager.ActiveApplication.GetWindow("New Project").Find.ByTextContent("Installed").User.Click();
            Manager.ActiveApplication.MainWindow.Find.ByTextContent("Visual C#").User.Click();
            Manager.ActiveApplication.MainWindow.Find.ByTextContent("Test").User.Click();
            Manager.ActiveApplication.MainWindow.Find.ByTextContent("Unit Test Project").User.Click();
            Manager.ActiveApplication.MainWindow.Find.ByName<TextBox>("txt_Name").SetText(false, "MyUnitTest", 10, 10, true);
            Manager.ActiveApplication.MainWindow.Find.ByName<TextBox>("txt_SlnName").SetText(false, "MyUnitTestsProject", 10, 10, true);
            Manager.ActiveApplication.MainWindow.Find.ByName<ComboBox>("cmb_Location").User.Click();
            Manager.Current.Desktop.KeyBoard.TypeText(@"C:\MyProjects");
            Manager.ActiveApplication.MainWindow.Find.ByName<Button>("btn_OK").User.Click();

            Manager.ActiveApplication.MainWindow.Find.ByName("MS_VS_TextEditorContent").Wait.ForVisible(30000);
            Assert.IsTrue(File.Exists(@"C:\MyProjects\MyUnitTestsProject\MyUnitTestsProject.sln"));

            BaseWpfTest.ShutDown();
            Thread.Sleep(2000);
            try
            {
                Directory.Delete(@"C:\MyProjects", true);
            }
            catch (Exception e)
            {
                Log.WriteLine("The process failed: " + e.Message);
            }
        }

        private string GetVisualStudioExecutable()
        {
            const string VisualStudioRegistryKeyPath = @"SOFTWARE\Microsoft\VisualStudio";
            const string VisualCSharpExpressRegistryKeyPath = @"SOFTWARE\Microsoft\VCSExpress";

            var vsVersions = new List<Version>
            {
                new Version("14.0"),
                new Version("12.0"),
                new Version("11.0"),
                new Version("10.0")
            };

            foreach (var version in vsVersions)
            {
                foreach (var isExpress in new bool[] { false, true })
                {
                    RegistryKey registryBase32 = RegistryKey.OpenBaseKey(
                        RegistryHive.LocalMachine,
                        RegistryView.Registry32);

                    RegistryKey vsVersionRegistryKey = registryBase32.OpenSubKey(
                        string.Format(
                            @"{0}\{1}.{2}",
                            isExpress ? VisualCSharpExpressRegistryKeyPath : VisualStudioRegistryKeyPath,
                            version.Major,
                            version.Minor));

                    if (vsVersionRegistryKey != null)
                    {
                        return vsVersionRegistryKey.GetValue("InstallDir", string.Empty) + "devenv.exe";
                    }
                }
            }

            return null;
        }
    }
}
