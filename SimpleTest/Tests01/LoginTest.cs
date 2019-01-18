using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pages01;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Helpers;

namespace Tests01
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        string loggedPage = "/products-page/your-account/?login=1";

        [Test]
        public void LoginTestB()
        {

            var loginPage = new LoginPageB();
            loginPage.OpenLoginPage(loginPageUrl);
            Assert.IsTrue(loginPage.IsLoginPageDisplayed());
            Assert.IsTrue(loginPage.IsLoginFormDisplayed());
            Assert.IsTrue(loginPage.IsLoginButtonisplayed());
            loginPage.FillLoginForm(email, password);
            loginPage.ClickLoginButton();
            Assert.AreEqual(loggedPage, new Uri(driver.Url).PathAndQuery);
            loginPage.IsLoggedBarDisplayed();
            loginPage.IsProfileLogoDisplayed();
            loginPage.ClickProfileLogo();
            var actualEmail = loginPage.GetEmail();
            Assert.AreEqual(email, actualEmail);

        }

    }
}
