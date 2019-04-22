﻿using AutoTest_B.UIElements;
using OpenQA.Selenium;
using NUnit.Framework;

namespace AutoTest_B
{
    [Parallelizable]

    class LoginInvalidUsername
    {
        IAlert alert;

        public IWebDriver Driver { get; set; }

        public LoginInvalidUsername()
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
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.FourCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password, Driver);

            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [Test]
        public void MoreThan12Chars()
        {
            Actions.FillLoginForm(Config.Credentials.Invalid.Username.ThirteenCharacters, Config.Credentials.Valid.Password, Config.Credentials.Valid.Password, Driver);

            alert = Driver.SwitchTo().Alert();

            Assert.AreEqual(Config.AlertsTexts.UsernameLengthOutOfRange, alert.Text);
            alert.Accept();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            Driver.Quit();
        }
    }
}