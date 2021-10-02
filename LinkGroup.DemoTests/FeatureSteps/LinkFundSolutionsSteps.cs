using LinkGroup.DemoTests.Functions;
using TechTalk.SpecFlow;

namespace LinkGroup.DemoTests.FeatureSteps
{
    [Binding]
    public class LinkFundSolutionsSteps
    {
        [Given(@"I have opened the Found Solutions page")]
        public void GivenIHaveOpenedTheFoundSolutionsPage()
        {
            LinkFundSolutionsHomepageFunctions.NavigateToLinkFundSolutonsHomepage();
        }

        [When(@"I view Funds")]
        public void WhenIViewFunds()
        {
            LinkFundSolutionsHomepageFunctions.HoverMouseOverFundsDropdownMenu();
        }

        [Then(@"I can select the investment managers for ""(.*)"" investors")]
        public void ThenICanSelectTheInvestmentManagersForInvestors(string jurisdiction)
        {
            LinkFundSolutionsHomepageFunctions.FundsSubMenuContainsItem(jurisdiction);
        }
    }
}