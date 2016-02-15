namespace FitnessApp
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Android;
    using OpenQA.Selenium.Appium.Service;
    using OpenQA.Selenium.Appium.Service.Options;
    using OpenQA.Selenium.Remote;

    using Views.MainView;
    using Views.PromptView;

    [TestClass]
    public abstract class BaseTest
    {
        private static AppiumLocalService service;
        private static AppiumDriver<AndroidElement> driver;

        private MainView mainView;
        private PromptView promptView;

        // [ClassInitialize]
        static BaseTest()
        {
            // Set your parameters
            const string YourAndroidDeviceName = "YOUR_ANDROID_DEVICE_NAME";
            const string YourUserName = "YOUR_USER_NAME";
            const string FullPathToFitnessApp = @"FULL_PATH_TO_FITNESS_APP\fitness-debug.apk";

            // Start Appium Server
            var avdOptions = new KeyValuePair<string, string>("--avd", YourAndroidDeviceName);
            var avdParamsOptions = new KeyValuePair<string, string>("--avd-args", "\"-scale 0.75\"");
            OptionCollector args = new OptionCollector();
            args.AddArguments(avdOptions);
            args.AddArguments(avdParamsOptions);

            service = new AppiumServiceBuilder()
                .WithAppiumJS(new FileInfo(@"C:\Users\" + YourUserName + @"\AppData\Roaming\npm\node_modules\appium\bin\appium.js"))
                .WithArguments(args).UsingAnyFreePort().Build();
            service.Start();
            Assert.IsTrue(service.IsRunning);

            // Start Appium Client
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("deviceName", YourAndroidDeviceName);
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("app", FullPathToFitnessApp);
            driver = new AndroidDriver<AndroidElement>(service.ServiceUrl, capabilities, TimeSpan.FromSeconds(180));

            // ClassCleanup substitute
            AppDomain.CurrentDomain.DomainUnload += ClassCleanup;
        }

        protected static AppiumDriver<AndroidElement> Driver
        {
            get
            {
                return driver;
            }
        }

        protected MainView MainView
        {
            get
            {
                return this.mainView;
            }
        }

        protected PromptView PromptView
        {
            get
            {
                return this.promptView;
            }
        }

        [TestInitialize]
        public void TestInit()
        {
            Driver.ResetApp();

            this.mainView = new MainView(driver);
            this.promptView = new PromptView(driver);

            var textView = driver.FindElementByClassName("android.widget.TextView");
            Assert.IsNotNull(textView, "Main view not loaded");
        }

        // [ClassCleanup]
        private static void ClassCleanup(object sender, EventArgs e)
        {
            Driver.Quit();
            service.Dispose();
        }
    }
}