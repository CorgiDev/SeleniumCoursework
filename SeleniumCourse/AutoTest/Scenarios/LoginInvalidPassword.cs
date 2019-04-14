using AutoTest.UIElements;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoTest.Scenarios
{
    class LoginInvalidPassword
    {
        IAlert alert;

        public LoginInvalidPassword()
        {
        }

        [SetUp]
        public void Initialize()
        {
            Actions.InitializeDriver();
            NavigateTo.LoginFormScenarioThroughTestCases();
        }

        [Test]
        public void LessThan5Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.FourCharacters, Config.Credentials.Invalid.Password.FourCharacters);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
