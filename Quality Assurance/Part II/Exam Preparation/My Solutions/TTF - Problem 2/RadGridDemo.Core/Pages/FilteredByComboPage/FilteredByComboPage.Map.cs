using Telerik.WebAii.Controls.Html;

namespace RadGridDemo.Core.Pages.GridFilteredByComboPage
{
    public partial class FilteredByComboPage : BasePage
    {
        public RadComboBox ContactName
        {
            get
            {
                this.Browser.WaitForElement(10000, "class=~RadComboBox");
                return this.Browser.Find.AllByExpression<RadComboBox>("class=~RadComboBox")[0];
            }
        }
    }
}
