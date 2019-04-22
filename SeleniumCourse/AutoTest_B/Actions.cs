using System;
using AutoTest_B;
using AutoTest_B.UIElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;

namespace AutoTest_B
{
    public static class Actions
    {
        public static IWebDriver InitializeDriver()
        {
            var capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "device");
            capabilities.SetCapability(MobileCapabilityType.BrowserName, "Chrome");

            IWebDriver driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities);
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
