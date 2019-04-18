using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;

class Program
{
    static void Main()
    {
        IWebDriver driver = new InternetExplorerDriver();

        driver.Navigate().GoToUrl("http://google.com");

        Actions actions = new Actions(driver);

        actions.KeyDown(Keys.Control).SendKeys("t").Build().Perform();
    }
}