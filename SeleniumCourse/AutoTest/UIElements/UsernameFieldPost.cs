using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTest.UIElements
{
    public class UsernameFieldPost
    {
        public UsernameFieldPost()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginFormLink { get; set; }

    }
}