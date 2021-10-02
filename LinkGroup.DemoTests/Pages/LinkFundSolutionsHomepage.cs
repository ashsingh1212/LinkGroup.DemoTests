using OpenQA.Selenium;

namespace LinkGroup.DemoTests.Pages
{
    public static class LinkFundSolutionsHomepage
    {
        public static By FundsMenuOption => By.Id("navItem-funds");
        public static By FundsSubMenuOptions(string jurisdiction)
        {
            return By.XPath($"//li[@id='navItem-funds']//a[contains(text(),'Investment Managers for {jurisdiction} investors')]");
        }
    }
}