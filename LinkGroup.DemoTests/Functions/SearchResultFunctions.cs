using LinkGroup.DemoTests.Extensions;
using LinkGroup.DemoTests.Pages;

namespace LinkGroup.DemoTests.Functions
{
    public class SearchResultFunctions
    {
        /// <summary>
        /// Validate the correct search term has been searched against
        /// </summary>
        /// <param name="searchTerm"></param>
        public static void ValidateCorrectSearchTermIsVisible(string searchTerm)
        {
            WebElementExtensions.AssertElementContainsText(SearchResultsPage.SearchTermText, searchTerm);
        }
    }
}