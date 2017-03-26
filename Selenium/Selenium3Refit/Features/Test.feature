Feature: Test

@mytag
Scenario: testSelenium3RefitSearch
Given I start Chrome browser and navigate to http://google.com
	And I have typed Selenium
    And I press ENTER key
	When I click 2 link
	Then the title page is Selenium (software) - Wikipedia
	And Chrome browser closes
	