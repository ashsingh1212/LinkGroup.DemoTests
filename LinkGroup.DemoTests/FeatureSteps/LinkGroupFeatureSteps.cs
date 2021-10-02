using LinkGroup.DemoTests.Functions;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests.FeatureSteps
{
    [Binding]
    public class LinkGroupFeatureSteps
    {
        [Given(@"I have opened the home page")]
        [When(@"I open the home page")]
        public void WhenIOpenTheHomePage()
        {
            LinkGroupHomepageFunctions.NavigateToLinkGroupHomepage();
        }

        [Then(@"the page is displayed")]
        public void ThenThePageIsDisplayed()
        {
            LinkGroupHomepageFunctions.AssertPageTitleIsCorrect();
        }

        [Given(@"I have agreed to the cookie policy")]
        public void GivenIHaveAgreedToTheCookiePolicy()
        {
            CookieNoticeFunctions.AcceptTrackingCookies();
        }

        [When(@"I search for (.*)")]
        public void WhenISearchFor(string searchValue)
        {
            LinkGroupHomepageFunctions.CarryOutSearch(searchValue);
        }

        [Then(@"the search results are displayed")]
        public void ThenTheSearchResultsAreDisplayed()
        {
            SearchResultFunctions.ValidateCorrectSearchTermIsVisible("You searched for: \"Leeds\"");
        }
    }
}