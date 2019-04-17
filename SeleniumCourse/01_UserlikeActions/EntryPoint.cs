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

        ///////////////////////////////////////////
        //Checks if the color of the 1st element
        //is the correct color while being hovered
        //over and checks the second to make sure
        //it is different.
        ///////////////////////////////////////////
        //string lightGreen = "rgba(144, 238, 144, 1)";
        //actions.MoveToElement(elements[0]).Build().Perform();
        //Console.WriteLine(elements[0].GetCssValue("background-color") == lightGreen);
        //Console.WriteLine(elements[1].GetCssValue("background-color") == lightGreen);

        //Drags the first element down to the location of the second element and then releases it.
        MoveElement(actions, elements[0], elements[1], 0, 10);
    }

    static void MoveElement(Actions actions, IWebElement from, IWebElement to, int x = 0, int y = 0)
    {
        actions.ClickAndHold(from)
            .MoveToElement(to)
            .MoveByOffset(x , y)
            .Release()
            .Build()
            .Perform();
    }
}
