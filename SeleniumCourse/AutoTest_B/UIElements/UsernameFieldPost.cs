using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTest_B.UIElements
{
    public class UsernameFieldPost
    {
        public UsernameFieldPost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#post-74 > div > p > a")]
        public IWebElement LoginFormLink { get; set; }

    }
}