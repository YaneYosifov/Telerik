using Telerik.WebAii.Controls.Html;

namespace RadGridDemo.Core.Pages.AllControlsPage
{
	public partial class AllControlsPage
	{
        public RadSearchBox SearchField
        {
            get
            {
                return this.Browser.Find.ById<RadSearchBox>("DemoSearch_SearchBox");
            }
        }
	}
}
