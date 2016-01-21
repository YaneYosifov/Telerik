using ArtOfTest.Common.UnitTesting;

namespace RadGridDemo.Core.Pages.GridFilteredByComboPage
{
    public static class FilteredByComboPageAsserter
    {
        public static void AssertPageTitle(this FilteredByComboPage page, string expectedTitle)
        {
            Assert.Equals(page.Title, expectedTitle);
        }

        public static void AssertRowsCount(this FilteredByComboPage page, int expectedRowsCount)
        {
            Assert.Equals(page.GridRows.Count, expectedRowsCount);
        }
    }
}
