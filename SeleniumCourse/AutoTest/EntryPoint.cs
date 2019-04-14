using System;
using System.Threading;
using AutoTest;
using AutoTest.UIElements;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Remote;

namespace AutoTest
{
    public class EntryPoint
    {
        static void Main()
        {
            Driver.driver.Navigate().GoToUrl("http://testing.todorvachev.com");

            NavigateTo.LoginFormThroughMenu();

            Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);
        }
    }
}

