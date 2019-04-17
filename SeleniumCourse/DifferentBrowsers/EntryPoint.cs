using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;

class EntryPoint
{
    static void Main()
    {
        //IWebDriver fireDriver = new FirefoxDriver();
        IWebDriver operaDriver = new OperaDriver();

        //fireDriver.Navigate().GoToUrl("http://google.com");
        operaDriver.Navigate().GoToUrl("http://google.com");
    }
}
