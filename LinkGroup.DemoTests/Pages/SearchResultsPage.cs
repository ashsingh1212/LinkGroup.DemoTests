using OpenQA.Selenium;

namespace LinkGroup.DemoTests.Pages
{
    public static class SearchResultsPage
    {
        public static By SearchTermText => By.XPath("//section[@id='SearchResults']/h3[text()]");
    }
}