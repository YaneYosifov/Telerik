namespace Navigation.Tests
{
    using ArtOfTest.WebAii.Core;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Navigation.Core.Pages.CommonPage;

    [TestClass]
    public abstract class BaseTest
    {
        private Browser browser;
        private Manager manager;
        protected CommonPage commonPage;

        protected Browser Browser
        {
            get
            {
                return this.browser;
            }
        }

        [TestInitialize]
        public void TestInit()
        {
            Settings mySettings = new Settings();
            mySettings.Web.DefaultBrowser = BrowserType.Chrome;
            // mySettings.AnnotateExecution = true;

            this.manager = new Manager(mySettings);
            this.manager.Start();
            this.manager.LaunchNewBrowser();

            this.browser = Manager.Current.ActiveBrowser;
            this.browser.Window.Maximize();
            this.browser.AutoDomRefresh = true;
            this.browser.AutoWaitUntilReady = true;
            this.browser.CommandTimeOut = 10000;

            this.commonPage = new CommonPage(this.Browser);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.manager.Dispose();
        }
    }
}