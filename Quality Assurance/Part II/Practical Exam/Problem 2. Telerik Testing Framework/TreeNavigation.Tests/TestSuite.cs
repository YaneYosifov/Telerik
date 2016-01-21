namespace Navigation.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Navigation.Core.Pages.BuiltInHandlersPage;
    using Navigation.Core.Pages.CommonPage;
    using Navigation.Core.Pages.TestStudioPage;

    [TestClass]
    public class TestSuite : BaseTest
    {
        [TestMethod]
        public void VerifyTreeNavigation()
        {
            TestStudioPage testStudioPage = new TestStudioPage(this.Browser);
            testStudioPage.Navigate();
            testStudioPage.ExpandTree();

            BuiltInHandlersPage builtInHandlersPage = new BuiltInHandlersPage(this.Browser);
            commonPage.AssertPageTitle("Built-In Handlers");

            builtInHandlersPage.ClickHTMLPopUpsLink();
            commonPage.AssertPageTitle("HTML Popups");
        }
    }
}