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
    public abstract class MainPage
    {

        protected IWebDriver driver;

        protected MainPage()
        {
            driver = Browsers.GetDriver;
            PageFactory.InitElements(driver, this);
        }

    }
}

