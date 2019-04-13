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
        string url = "http://testing.todvachev.com/test-scenarios/register-form/";

        driver.Navigate().GoToUrl(url);

        driver.Quit();
    }
}

// Test Cases
//    1. Create a POM of the Register Form.
//    2. Check if all elements are visible
//    3. Fill out the register form with INVALID data and test if the registration passes
//    4. Fill out the register form with VALID data and test if the registration passes