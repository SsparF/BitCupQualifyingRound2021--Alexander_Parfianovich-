using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;


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
            Thread.Sleep(7000);
            driver.FindElement(By.PartialLinkText("Google Cloud Platform Pricing Calculator")).Click();
            Thread.Sleep(7000);
            driver.Navigate().Refresh();
            Thread.Sleep(7000);
            //driver.FindElement(By.Name("//*[@id='mainForm']/md-tabs/md-tabs-wrapper/md-tabs-canvas/md-pagination-wrapper/md-tab-item[1]/div/div")).Click();
            IWebElement click2 = driver.FindElement(By.Name("quantity")); 
            click2.Click();
            click2.Clear();
            click2.SendKeys("4");
            driver.FindElement(By.Id("select_value_label_66")).Click();
            driver.FindElement(By.Id("select_option_76")).Click();
            driver.FindElement(By.Id("select_value_label_67")).Click();
            driver.FindElement(By.Id("select_option_89")).Click();
            driver.FindElement(By.Id("select_value_label_70")).Click();
            driver.FindElement(By.Id("select_option_271")).Click();
            driver.FindElement(By.XPath("//*[@id='mainForm']/div[2]/div/md-card/md-card-content/div/div[1]/form/div[16]/button")).Click();
            IWebElement click3 = driver.FindElement(By.Name("nodesCount")); 
            click3.Click();
            click3.Clear();
            click3.SendKeys("1");
            driver.FindElement(By.XPath("//*[@id='mainForm']/div[2]/div/md-card/md-card-content/div/div[2]/form/div[4]/div[1]/md-input-container/md-checkbox"));
            driver.FindElement(By.Id("select_option_434")).Click();
            driver.FindElement(By.Id("select_option_453")).Click();
            driver.FindElement(By.Id("select_option_441")).Click();
            driver.FindElement(By.XPath("//*[@id='mainForm']/div[2]/div/md-card/md-card-content/div/div[2]/form/div[6]/div/md-input-container/md-checkbox")).Click();
            driver.FindElement(By.Id("select_value_label_117")).Click();
            driver.FindElement(By.Id("select_option_132")).Click();
            driver.FindElement(By.Id("select_value_label_118")).Click();
            driver.FindElement(By.Id("select_option_287")).Click();
            driver.FindElement(By.Id("select_value_label_119")).Click();
            driver.FindElement(By.Id("select_option_139")).Click();
            driver.FindElement(By.XPath("//*[@id='mainForm']/div[2]/div/md-card/md-card-content/div/div[2]/form/div[12]/button")).Click();
            driver.FindElement(By.XPath("//*[@id='email_quote']")).Click();
            
            IWebDriver driver2 = new ChromeDriver();
            driver2.Url = " https://yopmail.com/";
            driver2.FindElement(By.XPath("//*[@id='listeliens']/a[1]")).Click();
            driver2.FindElement(By.Id("cprnd")).Click();
            driver2.Quit();

            // driver.FindElement(By.Name("description")).Click();
            // Actions actions = new Actions(driver);
            // actions.SendKeys(Keys.LeftControl+"V").Build().Perform();
            
            // driver.FindElement(By.XPath("//*[@id='dialogContent_451']/form/md-dialog-actions/button[2]")).Click();

            driver.Quit();
        }
    }
}
