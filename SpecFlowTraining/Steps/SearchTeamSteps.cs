using Specflow.Framework;
using SpecFlowTraining.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTraining.Steps
{
    [Binding]
    public sealed class SearchTeamSteps
    {
        protected LocalDriverBuilder builder;
        protected string startingUrl;
        protected string targetBrowser;

        private readonly ScenarioContext _scenarioContext;

        public SearchTeamSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("User opens the Google Search URL")]
        public void GivenTheUserOpensTheGoogleSearchURL()
        {
            Console.WriteLine("Step Def Opens Google.com");
        }

        [When("User enters a search term as (.*)")]
        public void WhenTheUserEnterASearchTerm(string searchTerm)
        {
            //Special to this Selenium Framework
            LocalDriverBuilder builder = new LocalDriverBuilder();
            this.startingUrl = "http://google.com";
            this.targetBrowser = "Chrome";
            var driver = builder.Launch(targetBrowser, this.startingUrl);
            driver.Manage().Window.Maximize();
            //END Special to this Selenium Framework

            var homePage = new HomePage(driver);
            homePage.EnterSearchText(searchTerm);

            //Selenium Specific
            driver.Quit();
        }

        [Then("User is able to access the search page")]
        public void ThenTheUserIsAbleToAccessTheSearchPage()
        {
            //TODO: implement act (action) logic
            Console.WriteLine("Step Def Access Search Page");
        }

    }
}
