using System;
using System.Linq;
using ArtOfTest.WebAii.Core;

namespace RadGridDemo.Core.Pages.GridAutomaticOperationsPage
{
    public partial class AutomaticOperationsPage: BasePage
    {
        public AutomaticOperationsPage(Browser browser) : base(browser)
        {
        }

        public void ClickEditRandomRow()
        {
            var iconEdit = this.IconsEdit.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
            iconEdit.ScrollToVisible();
            iconEdit.MouseClick();
        }
    }
}
