using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using Helpers;

namespace Pages01
{
    public class HomePage : BasePage
    {
        [FindsBy(How = How.CssSelector, Using = "a.account_icon")]
        private IWebElement MyAccountButton;

        [FindsBy(How = How.ClassName, Using = "caroufredsel_wrapper")]
        private IWebElement HomepageLogo;

        [FindsBy(How = How.Id, Using = "post-31")]
        private IWebElement AccountLogo;

        public HomePage() : base()
        {

        }
        public bool IsHomePageOpened()
        {
            return HomepageLogo.Displayed;
        }
        public void ClickMyAccountButton()
        {
            MyAccountButton.Click();

        }

        public bool IsAccountButtonDisplayed()
        {
            return MyAccountButton.Displayed;


        }

        public bool IsAccountPageDisplayed()
        {
            return AccountLogo.Displayed;
        }
        public void OpenStartPage(string url)
        {
            Browsers.Goto(url);
        }
    }
}
