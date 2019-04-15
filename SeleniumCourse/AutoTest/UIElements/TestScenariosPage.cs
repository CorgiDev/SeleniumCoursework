using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace AutoTest.UIElements
{
    public class TestScenariosPage
    {
        public TestScenariosPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector,
            Using =
                "#main-content > article.mh-loop-item.clearfix.post-72.post.type-post.status-publish.format-standard.has-post-thumbnail.hentry.category-test-scenarios > div.mh-loop-content.clearfix > header > h3 > a")]
        public IWebElement LoginForm { get; set; }
    }
}
