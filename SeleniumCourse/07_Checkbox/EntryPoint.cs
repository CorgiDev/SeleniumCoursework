using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();

    private static IWebElement checkbox;

    static void Main()
    {
        string url = "";

        driver.Navigate().GoToUrl(url);

        driver.Quit();
    }
}
