namespace Navigation.Core.Pages.CommonPage
{
    public partial class CommonPage
    {
        public string Title
        {
            get
            {
                return this.Browser.PageTitle;
            }
        }
    }
}