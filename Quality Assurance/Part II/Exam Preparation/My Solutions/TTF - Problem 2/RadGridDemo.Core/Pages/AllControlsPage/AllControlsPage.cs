using ArtOfTest.WebAii.Core;

namespace RadGridDemo.Core.Pages.AllControlsPage
{
	public partial class AllControlsPage : BasePage
	{
		private string url = "http://demos.telerik.com/aspnet-ajax/";

		public AllControlsPage(Browser browser) : base(browser)
		{
		}

		public void Navigate()
		{
			this.Browser.NavigateTo(this.url);
			this.Browser.WaitUntilReady();
		}

		public void SearchDemos(string name)
		{
			this.SearchField.SetText(name);
            this.Browser.Desktop.Mouse.Click(MouseClickType.LeftClick, SearchField.GetRectangle());
            this.Browser.Desktop.KeyBoard.KeyPress(System.Windows.Forms.Keys.Enter);
        }
	}
}
