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
    public abstract class BasePage

    {
        protected IWebDriver driver;

        public BasePage()
        {
            driver = Browsers.GetDriver;
            PageFactory.InitElements(driver, this);
        }



    }
}
