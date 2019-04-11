using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();

    private static IWebElement checkbox;

    static void Main()
    {
        string url = "http://testing.todarvachev.com/special-elements/check-button-test-3/";

        driver.Navigate().GoToUrl(url);

        driver.Quit();
    }
}
