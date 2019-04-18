using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        IWebElement newTab;
        IWebElement newWindow;

        string url = "http://testing.todvachev.com/tabs-and-windows/new-tab/";
        string newTabSelector = "#post-182 > div > p:nth-child(1) > a:nth-child(1)";
        string newWindowSelector = "#post-182 > div > p:nth-child(1) > a:nth-child(3)";

        driver.Navigate().GoToUrl(url);

        newTab = driver.FindElement(By.CssSelector(newTabSelector));
        newWindow = driver.FindElement(By.CssSelector(newWindowSelector));

        newTab.Click();
    }
}