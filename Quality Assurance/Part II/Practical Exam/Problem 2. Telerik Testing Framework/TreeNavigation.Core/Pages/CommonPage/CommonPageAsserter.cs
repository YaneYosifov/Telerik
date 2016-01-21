namespace Navigation.Core.Pages.CommonPage
{
    using ArtOfTest.Common.UnitTesting;

    public static class CommonPageAsserter
    {
        public static void AssertPageTitle(this CommonPage page, string expectedTitle)
        {
            Assert.Equals(page.Title, expectedTitle);
        }
    }
}