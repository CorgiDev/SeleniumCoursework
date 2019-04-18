using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;

class Program
{
    static void Main()
    {
        //IWebDriver driver = new InternetExplorerDriver();
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://google.com");

        Actions actions = new Actions(driver);

        actions.KeyDown(Keys.Control).SendKeys("t").Build().Perform();

        ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
        ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
        ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
        ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
        ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
        ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
        ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
        ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");

        List<string> handles = driver.WindowHandles.ToList();

        driver.SwitchTo().Window(handles[2]);
        driver.Navigate().GoToUrl("http://gmail.com");

        for (int i = 0; i < handles.Count; i++)
        {
            if (i != 2)
            {
                driver.SwitchTo().Window(handles[i]);
                driver.Close();
            }
        }
    }
}