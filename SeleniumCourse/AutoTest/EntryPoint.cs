using AutoTest;
using OpenQA.Selenium.Interactions;

class EntryPoint
{
    public static string baseURL = "http://google.com";

    static void Main()
    {
        Actions.InitializeDriver();

        Driver.driver.Quit;

        //Actions.NavToLoginForm();

        //TestList.InvalidLogin(true);

        //TestList.ValidLogin(false, false);

        //TestList.ValidRegistration("testuser34", "1234567", "testemail13@testemaild.com", false);

        //Menu.Initialize();
    }
}
