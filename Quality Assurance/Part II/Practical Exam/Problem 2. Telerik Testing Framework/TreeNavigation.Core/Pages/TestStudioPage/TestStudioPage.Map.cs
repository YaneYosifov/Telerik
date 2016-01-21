namespace Navigation.Core.Pages.TestStudioPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class TestStudioPage
    {
        public HtmlSpan TestingFrameworkTreeItem
        {
            get
            {
                this.Browser.WaitForElement(5000, "TextContent=Testing Framework");
                return this.Browser.Find.ByExpression<HtmlSpan>("TextContent=Testing Framework");
            }
        }

        public HtmlSpan WriteTestsInCodeTreeItem
        {
            get
            {
                this.Browser.WaitForElement(5000, "TextContent=Write Tests in Code");
                return this.Browser.Find.ByExpression<HtmlSpan>("TextContent=Write Tests in Code");
            }
        }

        public HtmlSpan AdvancedTopicsSubTreeItem
        {
            get
            {
                this.Browser.WaitForElement(5000, "TextContent=Advanced Topics");
                return this.Browser.Find.AllByExpression<HtmlSpan>("TextContent=Advanced Topics")[1];
            }
        }

        public HtmlSpan HtmlPopupsAndDialogsSubTreeItem
        {
            get
            {
                this.Browser.WaitForElement(5000, "TextContent=HTML Popups and Dialogs");
                return this.Browser.Find.ByExpression<HtmlSpan>("TextContent=HTML Popups and Dialogs");
            }
        }

        public HtmlAnchor BuiltInHandlersSubTreeItem
        {
            get
            {
                this.Browser.WaitForElement(5000, "TextContent=Built-In Handlers");
                return this.Browser.Find.ByExpression<HtmlAnchor>("TextContent=Built-In Handlers");
            }
        }
    }
}