using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();

    private static IWebElement textbox;

    static void Main()
    {
        //string url = "http://corgidev.com/contact.html";
        string url = "http://testing.todvachev.com/special-elements/text-input-field/";

        driver.Navigate().GoToUrl(url);

        //textbox = driver.FindElement(By.Name("userName"));
        textbox = driver.FindElement(By.Name("username"));

        textbox.SendKeys("Test Text");

        Thread.Sleep(3000);

        Console.WriteLine(textbox.GetAttribute(("value")));

        Thread.Sleep(3000);

        // Clears the textbox contents
        // textbox.Clear();

        //The lines below can only be used with a textbox that has a maxlength property. Switch which url variable and textbox variable is commented out accordingly.
        Console.WriteLine(textbox.GetAttribute(("maxlength")));

        Thread.Sleep(3000);

        driver.Quit();
    }
}