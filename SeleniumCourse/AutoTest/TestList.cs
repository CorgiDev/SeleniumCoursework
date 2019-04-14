using System;
using System.Threading;
using OpenQA.Selenium.Interactions;
using UIElements;

namespace AutoTest
{
    public static class TestList
    {
        public static void ValidLogin(bool stayLoggedIn, bool closeBrowserWhenFinished)
        {
            LoginFormElements loginForm = new LoginFormElements();

            Actions.NavToLoginForm();

            loginForm.emailField.SendKeys(@"t@gmail.com");
            loginForm.passwordField.SendKeys("1234567");
            loginForm.loginButton.Click();

            if (stayLoggedIn == false)
            {
                Actions.LogOut();
            }

            if (closeBrowserWhenFinished == true)
            {
                Actions.CloseBrowser();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Login with valid details passed!");
            Console.ResetColor();
        }

        public static void InvalidLogin(bool closeBrowserWhenFinished)
        {
            LoginFormElements loginForm = new LoginFormElements();
            HomePageElements homePage = new HomePageElements();

            Actions.NavToLoginFOrm();

            loginForm.emailField.SendKeys(@"t@gmail.com");
            loginForm.passwordField.SendKeys("1234567");
            loginForm.loginButton.Click();

            Thread.Sleep(300); // Need to wait for animation to end and play button to become visible if test logged successfully.

            try
            {
                homePage.playButton.Click();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Login with invalid details passed!");
                Console.ResetColor();
            }
            catch (System.Reflection.TargetInvocationException) //element is not clickable exception
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Login with invalid details did NOT pass!");
                Console.ResetColor();
            }

            if (closeBrowserWhenFinished == true)
            {
                Actions.CloseBrowser();
            }
        }

        public static void ValidRegistration()
        {
        }
    }
}
