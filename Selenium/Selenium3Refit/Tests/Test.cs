using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Selenium3Refit.Pages;
using TechTalk.SpecFlow;

namespace Selenium3Refit.Tests
{
    [Binding]
    class Test : MainTest
    {

        [Given(@"I start Chrome browser and navigate to (.*)")]
        public void start(String address)
        {
            initialize(address);
        }


        [Given(@"I have typed (.*)")]
        public void typeValue(string value)
        {
            GooglePage googlePage = new GooglePage(); 
            googlePage.googleInput.SendKeys(value); 
        }

        [Given(@"I press ENTER key")]
        public void pressENTERKey()
        {
            GooglePage googlePage = new GooglePage();
            googlePage.googleSearchIcon.Click();
        }

        [When(@"I click (.*) link")]
        public void clickElement(int element)
        {
            GooglePage googlePage = new GooglePage();
            googlePage.googleLink.Click();
        }

        [Then(@"the title page is (.*)")]
        public void verifyPageIsLoaded(String title)
        {
            Assert.AreEqual(title, driver.Title);
        }

        [Then(@"Chrome browser closes")]
        public void ThenChromeBrowserCloses()
        {
            cleanUp();
        }


    }
}
