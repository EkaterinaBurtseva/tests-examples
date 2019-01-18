using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using NUnit.Framework;
using Page;
using Properties;
using RelevantCodes.ExtentReports;
using static Properties.ExtentR;

namespace Tests
{
    [TestFixture]
    public class HomeTest : BaseTest
    {
        private string homeTitle = "Specialists in creating digital business - Itera";
        private string uaLocationLink = "https://itera.no/ua/";

        [Test]
        public void HomePageTestStart()
        {
            var homePage = new HomeP();
            Check.Equals(homeTitle, driver.Title, false, "Titles aren't equal");
            test.Log(LogStatus.Pass, "Title is correct");
        }

        [Test]
        public void OpenVacanciesPage()
        {
            var homePage = new HomeP();
            test.Log(LogStatus.Info, "Click menu button");
            homePage.ClickMenuButton();
            Check.IsTrue(homePage.IsGamburgerMenuOpened());
            test.Log(LogStatus.Pass, "Gamburger menu is opened");
            test.Log(LogStatus.Info, "Click Itera Link");
            homePage.ClickYouAtIteraLink();
            Check.IsTrue(homePage.IsGamburgerMenu2Opened());
            test.Log(LogStatus.Pass, "Gamburger menu is opened");
            test.Log(LogStatus.Info, "Click Vacancies Link");
            homePage.ClickVacanciesLink();
            var vacanciesPage = new VacanciesP();
            Check.IsTrue(vacanciesPage.IsVacanciesPageDisplayed());
            test.Log(LogStatus.Pass, "Vacancies page is opened");
        }

        [Test]
        public void ChangeLocation()
        {
            var homePage = new HomeP();
            test.Log(LogStatus.Info, "Click location selector");
            homePage.ClickLocationSelector();
            test.Log(LogStatus.Info, "Click Ukraine location");
            homePage.SelectUALOcation();
            Check.Equals(uaLocationLink, driver.Url, true, "test");
            test.Log(LogStatus.Pass, "Location changed to Ukraine");
        }
    }

}
