using Microsoft.VisualStudio.TestTools.UnitTesting;
using RadGridDemo.Core.Pages.AllControlsPage;
using RadGridDemo.Core.Pages.GridAutomaticOperationsPage;
using RadGridDemo.Core.Pages.GridFilteredByComboPage;

namespace RadGridDemo.Tests
{
	[TestClass]
	public class TestSuite : BaseTest
	{
		[TestMethod]
		public void VerifyFiltering()
		{
            AllControlsPage allControlsPage = new AllControlsPage(this.Browser);
            allControlsPage.Navigate();
            allControlsPage.SearchDemos("Grid Filtered by Combo");

            FilteredByComboPage gridFilteredByComboPage = new FilteredByComboPage(this.Browser);
            gridFilteredByComboPage.AssertPageTitle("ASP.NET ComboBox Demo - Grid Filtered by Combo");

            gridFilteredByComboPage.SelectContact("Regina Murphy");
            gridFilteredByComboPage.AssertRowsCount(3);

            gridFilteredByComboPage.RestoreBrowser();
            gridFilteredByComboPage.AssertRowsCount(3);
        }

        [TestMethod]
        public void  VerifyFieldText()
        {
            AllControlsPage allControlsPage = new AllControlsPage(this.Browser);
            allControlsPage.Navigate();
            allControlsPage.SearchDemos("Automatic Operations");

            AutomaticOperationsPage gridAutomaticOperationsPage = new AutomaticOperationsPage(this.Browser);
            gridAutomaticOperationsPage.AssertPageTitle("Automatic CRUD operations in ASP.NET AJAX Grid | RadGrid demo");

            gridAutomaticOperationsPage.ClickEditRandomRow();
            gridAutomaticOperationsPage.AssertContactTitle();

            gridAutomaticOperationsPage.RestoreBrowser();
            gridAutomaticOperationsPage.AssertRowsCount(10);
        }
    }
}
