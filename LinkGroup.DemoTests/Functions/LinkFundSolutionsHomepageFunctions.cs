using LinkGroup.DemoTests.Extensions;
using LinkGroup.DemoTests.Pages;

namespace LinkGroup.DemoTests.Functions
{
    public static class LinkFundSolutionsHomepageFunctions
    {
        /// <summary>
        /// Navigate to Link Fund Solutions homepage
        /// </summary>
        public static void NavigateToLinkFundSolutonsHomepage()
        {
            WebElementExtensions.NavigateToUrl("https://www.linkfundsolutions.co.uk/");
        }

        /// <summary>
        /// Hover over Funds menu icon to view the dropdown menu options
        /// </summary>
        public static void HoverMouseOverFundsDropdownMenu()
        {
            WebElementExtensions.HoverOverElement(LinkFundSolutionsHomepage.FundsMenuOption);
        }

        /// <summary>
        /// Go through all Funds sub menu options and validate particular jurisdiction exists within each link
        /// </summary>
        /// <param name="value"></param>
        public static void FundsSubMenuContainsItem(string jurisdiction)
        {
            WebElementExtensions.AssertElementIsVisible(LinkFundSolutionsHomepage.FundsSubMenuOptions(jurisdiction));
        }
    }
}