using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace Selenium3Refit.Pages
{
    class GooglePage
    {

        public GooglePage()
        {
            PageFactory.InitElements(MainTest.driver, this); 
        }


        [FindsBy(How = How.XPath, Using = "//input[@name='q']")]
        public IWebElement googleInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@name='btnG']")]
        public IWebElement googleSearchIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='ires']/div/div/div/div[2]/div/h3/a")]
        public IWebElement googleLink { get; set; }

    }
}
