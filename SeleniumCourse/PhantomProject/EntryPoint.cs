using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PhantomJS
{
    class Program
    {
        static void Main()
        {
            //Headless option for ChromeDriver
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");

            //ChromeDriver
            IWebDriver driver = new ChromeDriver(options);

            string sitemapURL = "http://testing.todvachev.com/sitemap-posttype-post.xml";
            string[] pageSource;

            driver.Navigate().GoToUrl(sitemapURL);

            pageSource = driver.PageSource.Split(' ');
        }
    }
}

