using System.Collections.Generic;
using ArtOfTest.WebAii.Controls.HtmlControls;
using Telerik.WebAii.Controls.Html;

namespace RadGridDemo.Core.Pages.GridAutomaticOperationsPage
{
    public partial class AutomaticOperationsPage : BasePage
    {
        public IEnumerable<HtmlSpan> IconsEdit
        {
            get
            {
                this.Browser.WaitForElement(10000, "class=~rgEditIcon");
                return this.Browser.Find.AllByExpression<HtmlSpan>("class=~rgEditIcon");
            }
        }

        public string GridRowExpandedColumnTitleText
        {
            get
            {
                this.Browser.WaitForElement(10000, "class=rgEditRow");
                var grid = this.Browser.Find.ById<RadGrid>("ctl00_ContentPlaceholder1_RadGrid1");
                var row = grid.Find.ByExpression<HtmlTableRow>("class=rgEditRow");
                return row.Cells[3].TextContent;
            }
        }

        public HtmlInputText ContactTitle
        {
            get
            {
                this.Browser.WaitForElement(3000, "class=rgEditForm");
                return this.Browser.Find.ByExpression<HtmlInputText>("xpath=//div[@class='rgEditForm']/table/tbody/tr[4]/td[2]/input");
            }
        }
    }
}
