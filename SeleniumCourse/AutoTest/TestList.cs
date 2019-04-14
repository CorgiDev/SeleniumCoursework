using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

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

            Actions.NavToLoginForm();

            LoginForm.emailField.SendKeys(@"t@gmail.com");
            loginForm.passwordField.SendKeys("12345678");
            loginForm.loginButton.Click();

            Thread.Sleep(300); //Need to wait for animation to end and the play button to become visible if the test completed successfully.

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

            if (closeBrowserWhenFinished ==  true)
            {
                Actions.CloseBrowser();
            }
        }

        public static void ValidRegistration(string username, string password, string email, bool closeBrowserWhenFinished)
        {
        }
    }
}
