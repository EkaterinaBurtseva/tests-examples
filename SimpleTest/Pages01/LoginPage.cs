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

    public class LoginPageB : BasePage
    {
        [FindsBy(How = How.Id, Using = "post-31")]
        private IWebElement LoginLogo;

        [FindsBy(How = How.Id, Using = "log")]
        private IWebElement UserNameLogin;

        [FindsBy(How = How.Id, Using = "pwd")]
        private IWebElement PasswordLogin;

        [FindsBy(How = How.Id, Using = "login")]
        private IWebElement LoginBtn;

        [FindsBy(How = How.Id, Using = "login_wrapper")]
        private IWebElement LoginForm;

        [FindsBy(How = How.Id, Using = "wpadminbar")]
        private IWebElement LoggedBar;

        [FindsBy(How = How.CssSelector, Using = "#wp-admin-bar-my-account a")]
        private IWebElement ProfileName;

        [FindsBy(How = How.CssSelector, Using = "input#email")]
        private IWebElement ProfileEmail;

        public LoginPageB() : base()
        {
        }

        public bool IsLoginFormDisplayed()
        {
            return LoginForm.Displayed;
        }
        public bool IsLoginButtonisplayed()
        {
            return LoginBtn.Displayed;
        }

        public void FillLoginForm(string email, string password)
        {
            UserNameLogin.SendKeys(email);
            PasswordLogin.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginBtn.Click();
            driver.FindElement(By.Id("wpadminbar"), 5);
        }
        public void OpenLoginPage(string loginPageUrl)
        {
            driver = Browsers.GetDriver;
            driver.Navigate().GoToUrl(loginPageUrl);
        }
        public bool IsLoginPageDisplayed()
        {
            return LoginLogo.Displayed;
        }

        public bool IsProfileLogoDisplayed()
        {
            return ProfileName.Displayed;
        }
        public bool IsLoggedBarDisplayed()
        {
            return LoggedBar.Displayed;

        }
        public void ClickProfileLogo()
        {
            ProfileName.Click();
            driver.FindElement(By.Id("wpbody-content"), 3);
            driver.FindElement(By.Id("email"), 3);
        }
        public string GetEmail()
        {
            return ProfileEmail.GetAttribute("value");

        }

    }
}
