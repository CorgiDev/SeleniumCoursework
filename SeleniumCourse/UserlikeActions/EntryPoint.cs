using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

class EntryPoint
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        string url = "http://testing.todvachev.com/draganddrop/draganddrop.html";

        driver.Navigate().GoToUrl(url);

        string[] elementIDs =
        {
            "Drag1",
            "Drag2",
            "Drag3",
            "Drag4",
            "Drag5"
        };

        IWebElement[] elements =
        {
            driver.FindElement(By.Id(elementIDs[0])),
            driver.FindElement(By.Id(elementIDs[1])),
            driver.FindElement(By.Id(elementIDs[2])),
            driver.FindElement(By.Id(elementIDs[3]))
        };

        Actions actions = new Actions(driver);

        actions.MoveToElement(elements[0]).Build().Perform();
        
        ////////////////////////////////////////////
        // The below section goes through the set
        // of draggable elements on the page and
        // tells me if it is one of the 2 valid
        // colors, or not.
        ////////////////////////////////////////////
        string lightGreen = "rgba(144, 238, 144, 1)";
        string navajoWhite = "rgba(255, 222, 173, 1)";

        Console.WriteLine("The color of the button on hover should be Light Green, and Navajo White otherwise.");

        for (int i=0; i < elements.Length; i++)
        {
            string elementColor = elements[i].GetCssValue("background-color");

            if (elementColor == lightGreen)
            {
                Console.WriteLine("Element number " + (i + 1) + " is light green.");
            }
            else if (elementColor == navajoWhite)
            {
                Console.WriteLine("Element number " + (i + 1) + " is navajo white.");
            }
            else
            {
                Console.WriteLine("Element number " + (i + 1) + " is not a recognized color.");
            }
        }
    }
}
