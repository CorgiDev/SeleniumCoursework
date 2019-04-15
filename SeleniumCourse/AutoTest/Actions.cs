using AutoTest;
using AutoTest.UIElements;
using OpenQA.Selenium.Chrome;

namespace AutoTest
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.baseURL);
            Driver.WaitForElementUpTo(Config.ElementsWaitingTimeout);
        }

        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginScenarioPost lsPost = new LoginScenarioPost();

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
