using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement dropDownMenu;
    private static IWebElement elementFromTheDropDownMenu;

    static void Main()
    {
        string url = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        string dropDownMenuElement = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";

        driver.Navigate().GoToUrl(url);

        dropDownMenu = driver.FindElement(By.Name("DropDownTest"));

        //List currently selected drop-down item
        Console.WriteLine("The initially selected value is: " + dropDownMenu.GetAttribute("value"));

        //List a specific drop-down menu item
        elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElement));

        Console.WriteLine("The third option from the drop-down menu is: " + elementFromTheDropDownMenu.GetAttribute("value"));

        elementFromTheDropDownMenu.Click();  //This is what actually sets the 3rd option as the currently selected value

        Console.WriteLine(dropDownMenu.GetAttribute("value"));

        Thread.Sleep(3000);

        //List all Drop-Down Menu options
        Console.WriteLine("Drop-Down Menu Options");

        for (int i = 1; i <= 4; i++)
        {
            dropDownMenuElement = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";
            elementFromTheDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElement));

            Console.WriteLine("Option " + i + " : " + elementFromTheDropDownMenu.GetAttribute("value"));
        }

        driver.Quit();
    }
}