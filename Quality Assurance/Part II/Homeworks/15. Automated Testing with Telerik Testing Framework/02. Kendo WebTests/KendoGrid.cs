namespace KendoWebTests
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;
    using ArtOfTest.WebAii.TestTemplates;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Summary description for KendoGrid
    /// </summary>
    [TestClass]
    public class KendoGrid : BaseTest
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

            // Pass in 'true' to recycle the browser between test methods
            Initialize(true, this.TestContext.TestLogsDir, new TestContextWriteLine(this.TestContext.WriteLine));

            // If you need to override any other settings coming from the
            // config section you can comment the 'Initialize' line above and instead
            // use the following:

            /*

            // This will get a new Settings object. If a configuration
            // section exists, then settings from that section will be
            // loaded

            Settings settings = GetSettings();

            // Override the settings you want. For example:
            settings.Web.DefaultBrowser = BrowserType.FireFox;

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

            // Shuts down WebAii manager and closes all browsers currently running
            // after each test. This call is ignored if recycleBrowser is set
            this.CleanUp();

            #endregion
        }

        //Use ClassCleanup to run code after all tests in a class have run
        [ClassCleanup()]
        public static void MyClassCleanup()
        {
            // This will shut down all browsers if
            // recycleBrowser is turned on. Else
            // will do nothing.
            ShutDown();
        }

        #endregion

        private const int ColsQuantity = 5;
        private const int RowsQuantity = 21;

        [TestMethod]
        public void NavigateToKendoGridPage()
        {
            this.Manager.LaunchNewBrowser(BrowserType.Chrome);
            ActiveBrowser.NavigateTo("http://www.telerik.com/support/demos");
            Thread.Sleep(1000);

            Find.ByAttributes<HtmlAnchor>("href=http://demos.telerik.com/kendo-ui").Click();
            var h1 = Find.AllByTagName("h1").FirstOrDefault()?.InnerText;
            StringAssert.StartsWith(h1, "Kendo UI");

            Find.ByContent<HtmlAnchor>("Grid").Click();
            Find.ByContent<HtmlAnchor>("Initialization from table").Click();
        }

        [TestMethod]
        public void VerifyKendoGridHasCorrectQuantityOfRowsAndCols()
        {
            this.NavigateToKendoGridPage();

            var table = this.GetTable("grid");
            var rows = this.GetRows(table);
            Assert.AreEqual(rows.Count, RowsQuantity);
            Assert.AreEqual(rows.Count(tr => tr.ChildNodes.Count == ColsQuantity), RowsQuantity);
        }

        [TestMethod]
        public void VerifyColumnSorting()
        {
            this.NavigateToKendoGridPage();

            var colNames = Find.AllByAttributes<HtmlAnchor>("class=k-link", "href=#");
            for (int i = 0; i < ColsQuantity; i++)
            {
                colNames[i].Click();
                var sortedTable = this.GetTable("grid");
                var sortedRows = this.GetRows(sortedTable);

                var sortedCol = sortedRows.Select(tr => tr.ChildNodes[i]).ToList();
                for (int j = 0; j < RowsQuantity - 1; j++)
                {
                    int result = string.Compare(sortedCol[j].InnerText, sortedCol[j + 1].InnerText);
                    Assert.AreNotEqual(result, 1);
                }
            }
        }

        private HtmlTable GetTable(string id)
        {
            var table = Find.ById<HtmlTable>(id);
            return table;
        }

        private ReadOnlyCollection<Element> GetRows(HtmlTable table)
        {
            var rows = table.Find.AllByAttributes("role=row");
            return rows;
        }
    }
}
