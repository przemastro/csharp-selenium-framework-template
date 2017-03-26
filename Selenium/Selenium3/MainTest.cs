using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium3
{
    class MainTest
    {

        public IWebDriver driver;

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void initialize()
        {
            Console.WriteLine("Opening driver...");
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(System.Configuration.ConfigurationManager.AppSettings["address"]);
        }

        [TearDown]
        public void cleanUp()
        {
            driver.Close();
        }
    }
}
