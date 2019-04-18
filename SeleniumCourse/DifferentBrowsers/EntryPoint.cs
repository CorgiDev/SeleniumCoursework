using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;

class EntryPoint
{
    static void Main()
    {
        //IWebDriver fireDriver = new FirefoxDriver();
        //IWebDriver operaDriver = new OperaDriver();
        IWebDriver ieDriver = new InternetExplorerDriver();

        //fireDriver.Navigate().GoToUrl("http://google.com");
        //operaDriver.Navigate().GoToUrl("http://google.com");
        ieDriver.Navigate().GoToUrl("http://google.com");
    }
}
