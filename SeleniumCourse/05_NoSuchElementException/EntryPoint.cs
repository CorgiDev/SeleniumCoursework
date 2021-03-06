using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        string url = "http://corgidev.com/about.html";
        string cssPath = "#wrapper > section > img";
        //string xPath = "//*[@id=\"wrapper\"]/section/img";
        //Intentionally incorrect xPath below
        string xPath = "//*[@id=\"wrappers\"]/section/img"; 

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement cssPathElement;
        IWebElement xPathElement;

        try
        {
            cssPathElement = driver.FindElement(By.CssSelector(cssPath));

            if (cssPathElement.Displayed)
            {
                CorrectMessage("The CSS Path element is visible.");
            }
        }
        catch (NoSuchElementException)
        {
            ErrorMessage("The CSS Path element is not present.");
        }

        try
        {
            xPathElement = driver.FindElement(By.XPath(xPath));

            if (xPathElement.Displayed)
            {
                CorrectMessage("The xPath element is visible.");
            }
        }
        catch (NoSuchElementException)
        {
            ErrorMessage("The xPath element is not present.");
        }

        driver.Quit();
    }

    private static void CorrectMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void ErrorMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}