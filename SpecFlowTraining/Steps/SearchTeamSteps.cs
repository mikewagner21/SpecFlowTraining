using OpenQA.Selenium;
using SpecFlowTraining.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.Steps
{
    [Binding]
    sealed class SearchTeamSteps
    {
        private IWebDriver _driver;

        public SearchTeamSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"User opens the Google Search URL")]
        public void GivenTheUserOpensTheGoogleSearchURL()
        {
            _driver.Navigate().GoToUrl("https://www.google.com/");
            Console.WriteLine("Step Def Opens Google.com");
        }

        [When("User enters a search term as (.*)")]
        public void WhenTheUserEnterASearchTerm(string searchTerm)
        {
            var homePage = new HomePage(_driver);
            homePage.EnterSearchText(searchTerm);
        }

        [Then("User is able to access the search page")]
        public void ThenTheUserIsAbleToAccessTheSearchPage()
        {
            //TODO: implement act (action) logic
            Console.WriteLine("Step Def Access Search Page");
        }

    }
}
