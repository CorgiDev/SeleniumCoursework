using System;
using AutoTest;
using AutoTest.UIElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutoTest
{
    public static class Actions
    {
        public static IWebDriver InitializeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.baseURL);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return driver;
        }

        public static void FillLoginForm(string username, string password, string repeatPassword, IWebDriver driver)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost(driver);

            lsPost.UsernameField.Clear();
            lsPost.UsernameField.SendKeys(username);
            lsPost.PasswordField.Clear();
            lsPost.PasswordField.SendKeys(password);
            lsPost.RepeatPasswordField.Clear();
            lsPost.RepeatPasswordField.SendKeys(repeatPassword);
            lsPost.LoginButton.Click();
        }
    }
}
