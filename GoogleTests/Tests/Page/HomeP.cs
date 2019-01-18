using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Properties;

namespace Page
{
    public class HomeP : BaseP
    {

        public HomeP() : base()
        {

        }

        [FindsBy(How = How.Id, Using = "lga")]
        private IWebElement HomeLogo;

        [FindsBy(How = How.CssSelector, Using = "#gs_lc0 input")]
        private IWebElement HomeInput;

        [FindsBy(How = How.CssSelector, Using = "div.jsb input:nth-last-of-type(2)")]
        private IWebElement HomeEnter;

        [FindsBy(How = How.Id, Using = "tophf")]
        private IWebElement OtherElement;

        [FindsBy(How = How.CssSelector, Using = "div[data-hveid='53'] cite")]
        private IWebElement SecondBlock;

        [FindsBy(How = How.CssSelector, Using = "cite.iUh30")]
        private IList<IWebElement> Urls;

        [FindsBy(How = How.CssSelector, Using = "div.c2xzTb")]
        private IWebElement FeaturedSnippet;

        public void OpenStartPage(string baseURL)
        {
            Browsers.Goto(baseURL);
        }

        public bool IsHomePageOpened()
        {
            return HomeLogo.Displayed;
        }

        public void SearchForItem(string value)
        {
            driver.FindElement(By.CssSelector("#gs_lc0 input"), 2);
            HomeInput.SendKeys(value);
            driver.FindElement(By.CssSelector("body")).Click();
            HomeEnter.Click();
        }

        public string GetFirstUrl()
        {
            driver.FindElement(By.CssSelector("div[data-hveid='53'] cite"), 2);
            return SecondBlock.Text;
        }

        public bool IsWikipediaUrlDisplayed()
        {
            String[] allText1 = new String[Urls.Count];
            int i = 0;
            bool result = false;
            foreach (IWebElement element in Urls)
            {
                allText1[i++] = element.Text;
                if (element.Text.Contains("wikipedia"))
                {
                    return result = true;
                }
            }

            return result;
        }

        public bool IsHabrahabrUrlDisplayed()
        {
            String[] allText1 = new String[Urls.Count];
            int i = 0;
            bool result = false;
            foreach (IWebElement element in Urls)
            {
                allText1[i++] = element.Text;
                if (element.Text.Contains("habr.com"))
                {
                    return result = true;
                }
            }

            return result;
        }

        public bool IsFeaturedSnippetDisplayed()
        {
            return FeaturedSnippet.Displayed;
        }
    }

}




