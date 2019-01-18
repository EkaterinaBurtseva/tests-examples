using System;
using System.Text;
using System.Collections.Generic;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium;
using System.Collections.Specialized;
using Helpers;
using NUnit.Framework;
using System.Security.Policy;

namespace Tests01
{
    [TestFixture]
    public abstract class BaseTest
    {
        public IWebDriver driver;
        public string url;
        public string loginPageUrl = "http://store.demoqa.com/products-page/your-account/";
        public string registrPageUrl = "http://store.demoqa.com/wp-login.php?action=register";
        public string email = "burcevakate@gmail.com";
        public string password = "fC5m$I!(xO!5k^Aa";

        [OneTimeSetUp]
        public void InitDriver()
        {
            Browsers.Init();
            driver = Browsers.GetDriver;
        }


        [OneTimeTearDown]
        public void EndTest()
        {
            Browsers.Close();
        }

    }
}
