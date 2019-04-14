using System;
using AutoTest;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Remote;


class EntryPoint
    {
        static void Main()
        {
            Actions.InitializeDriver();

            Driver.driver.Quit();

            //Actions.NavToLoginForm();

            //TestList.InvalidLogin(true);

            //TestList.Validlogin();

            //TestList.ValidRegistration("", "", "", false);

            //Menu.Initialize();
        }
    }
