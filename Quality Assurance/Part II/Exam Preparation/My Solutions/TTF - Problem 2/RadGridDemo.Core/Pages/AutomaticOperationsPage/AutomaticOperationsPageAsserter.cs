using ArtOfTest.Common.UnitTesting;

namespace RadGridDemo.Core.Pages.GridAutomaticOperationsPage
{
    public static class AutomaticOperationsPageAsserter
    {
        public static void AssertPageTitle(this AutomaticOperationsPage page, string expectedTitle)
        {
            Assert.Equals(page.Title, expectedTitle);
        }

        public static void AssertContactTitle(this AutomaticOperationsPage page)
        {
            Assert.Equals(page.GridRowExpandedColumnTitleText, page.ContactTitle.Text);
        }

        public static void AssertRowsCount(this AutomaticOperationsPage page, int expectedRowsCount)
        {
            Assert.Equals(page.GridRows.Count, expectedRowsCount);
        }
    }
}
