using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System.Threading;
using Helpers;

namespace Pages01
{
    public class ShoppingPage : BasePage
    {

        //Page 1

        [FindsBy(How = How.Id, Using = "menu-item-33")]
        private IWebElement ProductCategory;

        [FindsBy(How = How.CssSelector, Using = "li.menu-item-36 a")]
        private IWebElement iPadCategory;

        [FindsBy(How = How.CssSelector, Using = "div.product_view_40")]
        private IWebElement iPadProduct;

        [FindsBy(How = How.CssSelector, Using = "div.product_view_40 a.wpsc_product_title")]
        private IWebElement iPadProductTitle;

        [FindsBy(How = How.CssSelector, Using = "p.product_40 span.currentprice")]
        private IWebElement iPadProductPrice;

        [FindsBy(How = How.CssSelector, Using = "div.product_view_40 div.input-button-buy input")]
        private IWebElement iPadAddToCart;

        [FindsBy(How = How.CssSelector, Using = "div#header_cart a")]
        private IWebElement Cart;

        //Page 2

        [FindsBy(How = How.ClassName, Using = "wpsc_product_name")]
        private IWebElement ProductNameCart;

        [FindsBy(How = How.CssSelector, Using = "a.step2")]
        private IWebElement ContinueBtn;

        [FindsBy(How = How.CssSelector, Using = "td.wpsc_product_name a")]
        private IWebElement ProductNameTitleStep2;

        [FindsBy(How = How.CssSelector, Using = "tr.product_row td:nth-last-of-type(3) span")]
        private IWebElement ProductPriceStep2;

        [FindsBy(How = How.ClassName, Using = "entry-content")]
        private IWebElement Step2Page;

        //Page 3

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_9")]
        private IWebElement EmailStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_2")]
        private IWebElement FirstNameStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_3")]
        private IWebElement LastNameStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_4")]
        private IWebElement AddressStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_5")]
        private IWebElement CityStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_6")]
        private IWebElement StateStep3;

        [FindsBy(How = How.CssSelector, Using = "select#wpsc_checkout_form_7  option:nth-last-of-type(16)")]
        private IWebElement CountryStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_8")]
        private IWebElement PostalCodeStep3;

        [FindsBy(How = How.Id, Using = "wpsc_checkout_form_18")]
        private IWebElement PhoneStep3;

        [FindsBy(How = How.CssSelector, Using = "input.make_purchase")]
        private IWebElement PurchaseBtn;

        [FindsBy(How = How.CssSelector, Using = "div.slide2")]
        private IWebElement PurchasePage;
        //Page 4

        [FindsBy(How = How.CssSelector, Using = "h1.entry-title")]
        private IWebElement FinalPage;

        [FindsBy(How = How.CssSelector, Using = "tr.total_item span.checkout-shipping span")]
        private IWebElement FinalPrice;

        [FindsBy(How = How.CssSelector, Using = "td.wpsc_product_remove input[name='submit']")]
        private IWebElement RemoveBtn;

        public ShoppingPage() : base()
        {
        }

        public void SelectIpadProduct()
        {
            iPadCategory.Click();
        }
        public string GetTitleOfProduct()
        {
            var actualTitle = iPadProductTitle.Text;
            return actualTitle;
        }

        public string GetPriceOfProduct()
        {
            var actualPrice = iPadProductPrice.Text;
            return actualPrice;
        }

        public void ClickAddtoCart()
        {
            iPadAddToCart.Click();
            driver.FindElement(By.CssSelector("[style*='display: block']"), 3);
        }

        public void ClickContinueButton()
        {

            ContinueBtn.Click();
            driver.FindElement(By.CssSelector("[style='display: block;']"), 3);

        }

        public void ClickPurchase()
        {
            PurchaseBtn.Click();
        }

        public void ClickGoToCart()
        {
            Cart.Click();

        }
        public bool IsCartDisplayed()
        {
            return Cart.Displayed;
        }

        public void FillFormWithData(string email, string defaultText)
        {
            EmailStep3.SendKeys(email);
            FirstNameStep3.SendKeys(defaultText);
            LastNameStep3.SendKeys(defaultText);
            AddressStep3.SendKeys(defaultText);
            CityStep3.SendKeys(defaultText);
            StateStep3.SendKeys(defaultText);
            CountryStep3.Click();
            PostalCodeStep3.SendKeys(defaultText);
            PhoneStep3.SendKeys(defaultText);

        }

        public bool IsElementDisplayedCart()
        {
            driver.FindElement(By.ClassName("wpsc_product_name"), 2);
            return ProductNameCart.Displayed;

        }
        public bool IsFinalPageDisplayed()
        {
            return FinalPage.Displayed;

        }

        public void Remove()
        {
            RemoveBtn.Click();
        }

        public void HoverProductCategory()
        {
            driver.FindElement(By.Id("menu-item-33"), 3);
            driver.HoverOvers(ProductCategory);
        }

        public string GetTitleProductStep2()
        {

            driver.FindElement(By.CssSelector("td.wpsc_product_name a"), 5);
            var actualTitleStep2 = ProductNameTitleStep2.Text;
            return actualTitleStep2;
        }

        public string GetPriceProductStep2()
        {
            driver.FindElement(By.CssSelector("tr.product_row td:nth-last-of-type(3) span"), 5);
            var actualPriceStep2 = ProductPriceStep2.Text;
            return actualPriceStep2;
        }

        public bool IsPurchasePageDisplayed()
        {

            driver.FindElement(By.CssSelector("div.slide2"), 10);
            return PurchasePage.Displayed;
        }
        public bool IsStep2PageDisplayed()
        {
            driver.FindElement(By.ClassName(classNameToFind: "entry-content"), 5);
            return Step2Page.Displayed;
        }


        public string GetFinalPrice()
        {
            driver.FindElement(By.CssSelector("tr.total_item span.checkout-shipping span"), 3);
            var finalPrice = FinalPrice.Text;
            return finalPrice;
        }
    }

}



