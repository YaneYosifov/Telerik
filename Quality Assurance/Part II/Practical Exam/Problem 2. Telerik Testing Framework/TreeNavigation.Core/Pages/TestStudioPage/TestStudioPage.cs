namespace Navigation.Core.Pages.TestStudioPage
{
    using ArtOfTest.WebAii.Core;

    public partial class TestStudioPage : BasePage
    {
        private string url = "http://docs.telerik.com/teststudio/";

        public TestStudioPage(Browser browser) : base(browser)
        {
        }

        public void Navigate()
        {
            this.Browser.NavigateTo(this.url);
            this.Browser.WaitUntilReady();
        }

        public void ExpandTree()
        {
            TestingFrameworkTreeItem.MouseClick();
            WriteTestsInCodeTreeItem.ScrollToVisible();
            WriteTestsInCodeTreeItem.MouseClick();
            AdvancedTopicsSubTreeItem.ScrollToVisible();
            AdvancedTopicsSubTreeItem.MouseClick();
            HtmlPopupsAndDialogsSubTreeItem.ScrollToVisible();
            HtmlPopupsAndDialogsSubTreeItem.MouseClick();
            BuiltInHandlersSubTreeItem.ScrollToVisible();
            BuiltInHandlersSubTreeItem.MouseClick();
        }
    }
}