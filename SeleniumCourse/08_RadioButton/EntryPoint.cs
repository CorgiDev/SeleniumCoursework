using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();

    static IWebElement checkBox;

    static void Main()
    {
        string url = "http://testing.todorvachev.com/special-elements/radio-button-test/";

        string option = "1";

        driver.Navigate().GoToUrl(url);

        driver.Quit();
    }
}
