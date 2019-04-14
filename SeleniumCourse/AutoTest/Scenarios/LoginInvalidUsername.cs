using AutoTest.UIElements;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoTest
{
    class LoginInvalidUsername
    {
        IAlert alert;

        public LoginInvalidUsername()
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
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password);

            alert = Driver.driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.driver.Quit();
        }
    }
}
