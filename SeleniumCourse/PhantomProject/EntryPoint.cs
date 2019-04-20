using System;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic; //Needed for the list below.
using System.IO;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        List<string> extractedLinks = new List<string>();

        //Headless option for ChromeDriver
        ChromeOptions options = new ChromeOptions();
        options.AddArgument("--headless");

        //ChromeDriver
        IWebDriver driver = new ChromeDriver(options);

        string sitemapURL = "http://testing.todvachev.com/sitemap-posttype-post.xml";
        string[] pageSource;

        int startIndex = 0;
        int linkLength = 0;

        driver.Navigate().GoToUrl(sitemapURL);

        pageSource = driver.PageSource.Split(' ');

        foreach (var item in pageSource)
        {
            if (item.Contains(@"href=""http://testing.todvachev.com"))
            {
                extractedLinks.Add(item);
                Console.WriteLine(item);
            }
        }
    }
}


