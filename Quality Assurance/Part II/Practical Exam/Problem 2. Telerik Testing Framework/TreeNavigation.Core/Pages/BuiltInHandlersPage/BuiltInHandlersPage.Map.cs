namespace Navigation.Core.Pages.BuiltInHandlersPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class BuiltInHandlersPage
    {
        public HtmlAnchor HTMLPopUpsLink
        {
            get
            {
                this.Browser.WaitForElement(5000, "TextContent=HTML Pop-ups");
                return this.Browser.Find.ByExpression<HtmlAnchor>("TextContent=HTML Pop-ups");
            }
        }
    }
}