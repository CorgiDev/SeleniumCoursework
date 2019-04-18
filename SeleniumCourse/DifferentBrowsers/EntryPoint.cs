using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;

class EntryPoint
{
    static void Main()
    {
        //IWebDriver driver = new FirefoxDriver();
        //IWebDriver driver = new OperaDriver();
        IWebDriver driver = new ChromeDriver();
        //IWebDriver driver = new InternetExplorerDriver();

        Console.WriteLine(driver.GetType().ToString());

        if (driver.GetType().ToString().Contains("InternetExplorer"))
        {
            driver.Navigate().GoToUrl("http://bing.com");
        }
        else if (driver.GetType().ToString().Contains("Chrome"))
        {
            driver.Navigate().GoToUrl("http://gmail.com");
        }
    }
}
