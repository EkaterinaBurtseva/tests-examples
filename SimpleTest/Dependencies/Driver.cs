using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Dependencies
{
    public class Driver
    {
        private static IWebDriver driverInstance;

        private Driver()
        {
        }

        public static IWebDriver DriverInstance
        {
            get
            {
                if (driverInstance == null)
                {
                    var profile = new ChromeDriver();
                    
                    driverInstance = new ChromeDriver();
                    

                }
                return driverInstance;
            }
        }

        public static void Close()
        {
            if (driverInstance != null)
            {
                driverInstance.Quit();
                driverInstance = null;
            }
        }
    }
}

