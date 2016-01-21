namespace Navigation.Core.Pages
{
    using ArtOfTest.WebAii.Core;

    public abstract partial class BasePage
    {
        private Browser browser;

        protected Browser Browser
        {
            get
            {
                return this.browser;
            }
        }

        public BasePage(Browser browser)
        {
            this.browser = browser;
        }
    }
}