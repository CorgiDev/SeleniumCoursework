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
        string url = "http://testing.todvachev.com/test-scenarios/login-form/";

        driver.Navigate().GoToUrl(url);

        driver.Quit();
    }
}

// Test Cases
//    1. Username field with less than 5 characters and a correct password (invalid login)
//    2. Username field with more than 12 characters and a correct password (invalid login) 
//    3. Username field with 5-12 characters and incorrect password (invalid login)
//    4. Username field with correct login credentials (valid login)