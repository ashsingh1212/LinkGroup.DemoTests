using LinkGroup.DemoTests.Extensions;
using LinkGroup.DemoTests.Pages;

namespace LinkGroup.DemoTests.Functions
{
    public class LinkGroupHomepageFunctions
    {
        /// <summary>
        /// Navigate to the Link Group homepage
        /// </summary>
        public static void NavigateToLinkGroupHomepage()
        {
            WebElementExtensions.NavigateToUrl("https://www.linkgroup.eu/");
        }

        /// <summary>
        /// Validate the page title is "Home"
        /// </summary>
        public static void AssertPageTitleIsCorrect()
        {
            WebElementExtensions.AssertPageTitleIsCorrect("Home");
        }

        /// <summary>
        /// Carry out a search on Link Group homepage
        /// </summary>
        /// <param name="searchValue"></param>
        public static void CarryOutSearch(string searchValue)
        {
            WebElementExtensions.Click(LinkGroupHomepage.SearchDropdownMenu);
            WebElementExtensions.InputValue(LinkGroupHomepage.SearchInput, searchValue);
            WebElementExtensions.Click(LinkGroupHomepage.SearchButton);
        }
    }
}