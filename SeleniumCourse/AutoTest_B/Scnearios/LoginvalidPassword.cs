using AutoTest_B.UIElements;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoTest_B
{
    [Parallelizable]
    //If I formatted it like the line below, it would be excluded from running in Parallel with any other tests I had.
    //[Parallelizable(ParallelScope.None)]

    class LoginInvalidPassword
    {
        IAlert alert;

        public IWebDriver Driver { get; set; }

        public LoginInvalidPassword()
        {
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            Driver = Actions.InitializeDriver();
            NavigateTo.LoginFormThroughPost(Driver);
        }

        [Test]
        public void LessThan5Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.FourCharacters, Config.Credentials.Invalid.Password.FourCharacters, Driver);

            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Invalid.Password.ThirteenCharacters, Config.Credentials.Invalid.Password.ThirteenCharacters, Driver);

            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.PasswordLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}
