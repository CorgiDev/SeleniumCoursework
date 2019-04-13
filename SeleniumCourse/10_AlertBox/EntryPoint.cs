using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IAlert alert;
    static IWebElement image;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/alert-box/";

        driver.Navigate().GoToUrl(url);

        alert = driver.SwitchTo().Alert();
        
        Console.WriteLine(alert.Text); //Displays text from alert box

        alert.Accept(); //Clicks the OK on the alert box to dismiss it

        //Try to select another element to confirm textbox is gone
        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img"));
        
        try
        {
            if (image.Displayed)
            {
                Console.WriteLine("The alert was successful and I can now see the image behind the alert.");
            }
        }
        catch (NoSuchElementException)
        {
            Console.WriteLine("Something went wrong.");
        }

        Thread.Sleep(3000);

        driver.Quit();
    }
}