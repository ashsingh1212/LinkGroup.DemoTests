using OpenQA.Selenium;

namespace LinkGroup.DemoTests.Pages
{
    public static class LinkGroupHomepage
    {
        public static By SearchDropdownMenu => By.Id("navbardrop");
        public static By SearchInput => By.XPath("//input[@name='searchTerm']");
        public static By SearchButton => By.XPath("//button[@class='btn btn-outline-default my-2 my-sm-0']");
    }
}