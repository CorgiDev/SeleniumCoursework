using System;
using AutoTest;
using AutoTest.UIElements;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Remote;


public class EntryPoint
    {
        static void Main()
        {
            Menu menu = new Menu();

            Driver.driver.Navigate().GoToUrl("http://testing.todorvachev.com");
            menu.Selectors.Click();
        }
    }
