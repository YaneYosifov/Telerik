using ArtOfTest.WebAii.Core;

namespace RadGridDemo.Core.Pages.GridFilteredByComboPage
{
    public partial class FilteredByComboPage : BasePage
    {
        public FilteredByComboPage(Browser browser) : base(browser)
        {
        }

        public void SelectContact(string name)
        {
            this.ContactName.SelectItemByText(name);
        }
    }
}
