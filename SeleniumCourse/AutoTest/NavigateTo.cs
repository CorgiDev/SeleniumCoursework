using System.Threading;
using AutoTest.UIElements;
using AutoTest;
using AutoTest.UIElements;

namespace AutoTest.UIElements
{
    public static class NavigateTo
    {
        public static void LoginFormThroughPost()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameFieldPost uftPost = new UsernameFieldPost();

            menu.TestCases.Click();
            tcPage.UsernameField.Click();
            uftPost.LoginFormLink.Click();
        }

        public static void LoginFormThroughMenu()
        {
            Menu menu = new Menu();
            TestScenariosPage tsPage = new TestScenariosPage();

            menu.TestScenarios.Click();
            tsPage.LoginForm.Click();
        }
    }
}
