using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Pages01;
using Helpers;

namespace Tests01
{
    [TestFixture]
    class HomeTest : BaseTest
    {
        string homePageTitle = "ONLINE STORE | Toolsqa Dummy Test site";

        [Test]
        public void HomePageTestStart()
        {
            var homePage = new HomePage();
            homePage.OpenStartPage(url);
            Assert.AreEqual(homePageTitle, driver.Title);
            Assert.IsTrue(homePage.IsHomePageOpened());
            Assert.IsTrue(homePage.IsAccountButtonDisplayed());
            homePage.ClickMyAccountButton();
            Assert.IsTrue(homePage.IsAccountPageDisplayed());

        }


    }
}
