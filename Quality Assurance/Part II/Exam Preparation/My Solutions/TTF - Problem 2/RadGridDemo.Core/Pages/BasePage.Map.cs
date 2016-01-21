using System.Collections.Generic;
using ArtOfTest.WebAii.Controls.HtmlControls;
using Telerik.WebAii.Controls.Html;

namespace RadGridDemo.Core.Pages
{
    public partial class BasePage
    {
        public string Title
        {
            get
            {
                return this.Browser.PageTitle;
            }
        }

        public ICollection<HtmlTableRow> GridRows
        {
            get
            {
                this.browser.WaitForElement(3000, "id=^ctl00_ContentPlaceholder1", "class=~RadGrid");
                var grid = this.Browser.Find.ByExpression<RadGrid>("id=^ctl00_ContentPlaceholder1", "class=~RadGrid");
                grid.Refresh();
                var rows = grid.Find.AllByExpression<HtmlTableRow>("class=~Row");
                return rows;
            }
        }
    }
}
