using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EpamTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://code.visualstudio.com/docs/languages/csharp";
        }
    }
}
