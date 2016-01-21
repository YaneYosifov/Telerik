using ArtOfTest.WebAii.Core;

namespace RadGridDemo.Core.Pages
{
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

        public void RestoreBrowser()
        {
            this.browser.Window.Restore();
        }
    }
}
