using System.Threading;
using AutoTest.UIElements;
using AutoTest;
using AutoTest.UIElements;
using OpenQA.Selenium;

namespace AutoTest.UIElements
{
    public static class NavigateTo
    {
        public static void LoginFormThroughPost(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestCasesPage tcPage = new TestCasesPage(driver);
            UsernameFieldPost uftPost = new UsernameFieldPost(driver);

            menu.TestCases.Click();
            tcPage.UsernameField.Click();
            uftPost.LoginFormLink.Click();
        }

        public static void LoginFormThroughMenu(IWebDriver driver)
        {
            Menu menu = new Menu(driver);
            TestScenariosPage tsPage = new TestScenariosPage(driver);

            menu.TestScenarios.Click();
            tsPage.LoginForm.Click();
        }
    }
}
