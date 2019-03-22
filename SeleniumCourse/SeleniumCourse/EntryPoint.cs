using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://corgidev.com/contact.html");

        IWebElement element = driver.FindElement(By.Name("contactForm"));

        if (element.Displayed)
        {
            CorrectMessage("Element is visible!");
        }
        else
        {
            ErrorMessage("Element not visible!");
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
