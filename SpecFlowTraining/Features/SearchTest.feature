Feature: SearchTest
	enter a search term into google
	
@SpecFlowTraining
Scenario: The user must be able to enter a search term into the search box
  Given User opens the Google Search URL
  When User enters a search term as Test Automation Unversity
  Then User is able to access the search page
