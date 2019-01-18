using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Page;
using Properties;
using RelevantCodes.ExtentReports;
using static Properties.ExtentR;


namespace Tests
{
    [TestFixture]
    public abstract class BaseTest
    {
        public IWebDriver driver;
        public string baseURL = "https://itera.no";
        protected ThreadLocal<ExtentTest> _test;


        [OneTimeSetUp]
        public void InitDriver()
        {
            Browsers.Init();
            driver = Browsers.GetDriver;
            ExtentR.StartTest();
            _test = new ThreadLocal<ExtentTest>();
        }
        [SetUp]
        public void Initialize()
        {
            test = extent.StartTest(TestContext.CurrentContext.Test.Name);
            _test.Value = test;
            var homePage = new HomeP();
            test.Log(LogStatus.Info, "Opening base page");
            homePage.OpenStartPage(baseURL);
            Assert.IsTrue(homePage.IsHomePageOpened());
            test.Log(LogStatus.Pass, "Home page is opened");

        }



        [OneTimeTearDown]
        public void EndTest()
        {
            Browsers.Close();
            ExtentR.EndTest();

        }

    }
}

