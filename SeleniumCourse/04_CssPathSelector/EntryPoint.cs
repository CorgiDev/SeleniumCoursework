using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        // The back slashes in the XPath below escape out the quote marks in it. You also have to remember to remove the extra spaces that are often placed within the xPath or else you will get errors. I included a commented out erroneous version with the escaped out quote marks, but the extra spaces not removed so you can see this for yourself by just swapping out which XPath is commented out.

        string url = "http://corgidev.com/about.html";
        string cssPath = "#wrapper > section > img";
        string xPath = "//*[@id=\"wrapper\"]/section/img";
        //string xPath = "//*[@id="wrapper"]/section/img";

        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl(url);

        IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

        if (cssPathElement.Displayed)
        {
            CorrectMessage("The CSS Path element is visible.");
        }
        else
        {
            ErrorMessage("The CSS Path element is not present.");
        }

        if (xPathElement.Displayed)
        {
            CorrectMessage("The XPath element is visible.");
        }
        else
        {
            ErrorMessage("The XPath element is not present.");
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