using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Properties
{
    public class Browsers
    {
        private static IWebDriver webDriver;
        public static string baseURL = ConfigurationManager.AppSettings["url"];
        private static string browser = ConfigurationManager.AppSettings["browser"].ToString();

        public static void Init()
        {
            switch (browser)
            {
                case "Chrome":
                    webDriver = new ChromeDriver();
                    break;

                case "Firefox":
                    webDriver = new FirefoxDriver();
                    break;
            }

            webDriver.Manage().Window.Maximize();

        }

        public static void Goto(string baseURL)
        {
            webDriver.Navigate().GoToUrl(baseURL);
        }
        public static string Title
        {
            get { return webDriver.Title; }
        }
        public static IWebDriver GetDriver
        {
            get { return webDriver; }
        }
        public static void Close()
        {
            webDriver.Quit();
        }
    }
}
