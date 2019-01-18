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
    public class HomeP : MainPage
    {

        public HomeP() : base()
        {

        }

        [FindsBy(How = How.ClassName, Using = "header__pageTitle")]
        private IWebElement HomeLogo;

        [FindsBy(How = How.CssSelector, Using = "button.burger")]
        private IWebElement MenuButton;

        [FindsBy(How = How.CssSelector, Using = "li.hide-for-medium a[href='#40']")]
        private IWebElement YouAtIteraLink;

        [FindsBy(How = How.Id, Using = "mCSB_1_container")]
        private IWebElement GamburgerMenu;

        [FindsBy(How = How.Id, Using = "mCSB_5_container")]
        private IWebElement GamburgerMenu2;

        [FindsBy(How = How.CssSelector, Using = "#mCSB_5_container li:nth-last-of-type(1) a")]
        private IWebElement VacanciesLink;

        [FindsBy(How = How.ClassName, Using = "header__countries")]
        private IWebElement LocationSelector;

        [FindsBy(How = How.ClassName, Using = "header__countries open")]
        private IWebElement LocationSelectorOpen;

        [FindsBy(How = How.CssSelector, Using = "a[hreflang='uk']")]
        private IWebElement LocationUA;

        public void OpenStartPage(string baseURL)
        {
            Browsers.Goto(baseURL);
        }

        public bool IsHomePageOpened()
        {
            return HomeLogo.Displayed;
        }

        public void ClickMenuButton()
        {
            driver.FindElement(By.ClassName("js-burger"), 4);
            MenuButton.Click();
        }

        public bool IsGamburgerMenuOpened()
        {
            return GamburgerMenu.Displayed;
        }

        public void ClickYouAtIteraLink()
        {
            driver.FindElement(By.CssSelector("li.hide-for-medium a[href='#40']"), 5);
            YouAtIteraLink.Click();
        }

        public bool IsGamburgerMenu2Opened()
        {
            driver.FindElement(By.Id("mCSB_5_container"), 5);
            return GamburgerMenu2.Displayed;
        }

        public void ClickVacanciesLink()
        {
            driver.FindElement(By.CssSelector("#mCSB_5_container li:nth-last-of-type(1) a"), 3);
            VacanciesLink.Click();
        }

        public void GoToVacanciesPage()
        {
            ClickMenuButton();
            ClickYouAtIteraLink();
            ClickVacanciesLink();
        }

        public void ClickLocationSelector()
        {
            driver.FindElement(By.CssSelector("div.header__countries"), 3);
            LocationSelector.Click();
        }

        public bool IsLocationDropdownOpened()
        {
            driver.FindElement(By.CssSelector("div.open"), 3);
            return LocationSelectorOpen.Displayed;
        }

        public void SelectUALOcation()
        {
            LocationUA.Click();
        }

    }

}




