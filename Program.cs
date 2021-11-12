using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EpamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://cloud.google.com/";
            IWebElement click1 = driver.FindElement(By.Name("q")); 
            click1.Click();
            click1.Clear();
            click1.SendKeys("Google Cloud Platform Pricing Calculator");
            click1.SendKeys(Keys.Enter);
            Thread.Sleep(5000);
            driver.FindElement(By.PartialLinkText("Google Cloud Platform Pricing Calculator")).Click();
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
