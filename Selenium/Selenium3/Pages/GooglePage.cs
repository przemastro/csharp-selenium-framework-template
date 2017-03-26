using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Pages
{
    class GooglePage
    {
        public GooglePage typeValue(IWebDriver driver, String value)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name='q']"))).SendKeys(value);
            return this;
        }

        public GooglePage pressEnterKey(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@name='btnG']"))).SendKeys(Keys.Enter);
            return this;
        }

        public GooglePage countElements(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("ires")));
            int counter = 1;
            Boolean flag = true;
            while (flag == true)
            {
                try
                {
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='ires']/div/div/div/div[" + counter + "]")));
                    flag = true;
                    counter++;
                }
                catch (Exception ex)
                {
                    flag = false;
                    Console.WriteLine(ex);
                }
                Console.WriteLine(flag.ToString());
            }
            Console.WriteLine(counter.ToString());
            return this;
        }

        public GooglePage clickElement(IWebDriver driver, int elementNumber)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@id='ires']/div/div/div/div[" + elementNumber + "]/div/h3/a"))).Click();
            return this;
        }
        
        public GooglePage verifyPageIsLoaded(IWebDriver driver, String title)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("firstHeading")));
            Assert.AreEqual(title, driver.Title);
            return this;
        } 
    }
}
