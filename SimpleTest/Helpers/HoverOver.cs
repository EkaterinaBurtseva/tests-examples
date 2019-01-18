using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class HoverOver
    {
        public static void HoverOvers(this IWebDriver driver, IWebElement elementToHover)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(elementToHover).Perform();

        }
    }
}
