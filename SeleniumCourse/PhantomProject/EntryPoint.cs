using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PhantomJS
{
    class Program
    {
        static void Main()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            IWebDriver driver = new ChromeDriver(options);
        }
    }
}

