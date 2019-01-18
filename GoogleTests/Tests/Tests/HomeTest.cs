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
        private string title = "Google";
        private string expectedUrl = "https://www.seleniumhq.org/";
        private string wrongTitle = "Title is wrong";


        [Test]
        public void HomePageGoogleStart()
        {
            var homePage = new HomeP();
            Check.Equals(title, driver.Title, false, wrongTitle);
        }

        [Test]
        public void SearchTest()
        {
            var homePage = new HomeP();
            test.Log(LogStatus.Info, "Searching for selenium");
            homePage.SearchForItem("selenium");
            var firstUrl = homePage.GetFirstUrl();
            Check.Equals(firstUrl, expectedUrl);
            test.Log(LogStatus.Pass, "First url is " + expectedUrl);
            Check.IsTrue(homePage.IsWikipediaUrlDisplayed());
            test.Log(LogStatus.Pass, "Wikipedia url is displayed on the page");
            Check.IsTrue(homePage.IsHabrahabrUrlDisplayed());
            test.Log(LogStatus.Pass, "Habrahabr url is displayed on the page");
            Check.IsTrue(homePage.IsFeaturedSnippetDisplayed());
            test.Log(LogStatus.Pass, "Featured snippet is displayed on the page");

        }
    }
}
