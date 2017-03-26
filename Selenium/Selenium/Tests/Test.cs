using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.Pages;

//namespace is like package
namespace Selenium
{
	class Test : MainTest
	{

        [Test]
        public void testSelenium2Search()
        {
            GooglePage googlePage = new GooglePage()
                .typeValue(driver, "Selenium") 
                .pressEnterKey(driver)
                .countElements(driver)
                .clickElement(driver, 2)
                .verifyPageIsLoaded(driver, "Selenium (software) - Wikipedia"); 
        }

	}
}
