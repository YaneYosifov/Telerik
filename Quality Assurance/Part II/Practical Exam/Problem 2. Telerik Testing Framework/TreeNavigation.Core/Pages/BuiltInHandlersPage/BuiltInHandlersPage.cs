namespace Navigation.Core.Pages.BuiltInHandlersPage
{
    using ArtOfTest.WebAii.Core;

    public partial class BuiltInHandlersPage : BasePage
    {
        public BuiltInHandlersPage(Browser browser) : base(browser)
        {
        }

        public void ClickHTMLPopUpsLink()
        {
            HTMLPopUpsLink.MouseClick();
        }
    }
}