using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Pages01;
using System;
using System.Threading;
using Helpers;
using Tests01;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;


namespace Tests01
{
    [TestFixture]
    public class ShoppingTest : BaseTest
    {
        private string defaultText = "test";
        private string purchaseUrl = "/products-page/checkout/";


        [Test]
        public void BuyIpadTest()
        {
            var loginPage = new LoginPageB();
            loginPage.OpenLoginPage(loginPageUrl);
            loginPage.FillLoginForm(email, password);
            loginPage.ClickLoginButton();

            var shopPage = new ShoppingPage();
            shopPage.HoverProductCategory();
            shopPage.SelectIpadProduct();
            var actualTitle = shopPage.GetTitleOfProduct();
            var actualPrice = shopPage.GetPriceOfProduct();
            shopPage.ClickAddtoCart();
            Assert.IsTrue(shopPage.IsCartDisplayed(), "Cart button should be visible");

            shopPage.ClickGoToCart();
            Assert.IsTrue(shopPage.IsStep2PageDisplayed());
            Assert.AreEqual(purchaseUrl, new Uri(driver.Url).PathAndQuery, "Verification that user redirected to Step2");
            Assert.IsTrue(shopPage.IsElementDisplayedCart(), "Verification that element in cart");
            var actualTitleStep2 = shopPage.GetTitleProductStep2();
            Assert.AreEqual(actualTitle, actualTitleStep2);
            var actualPriceStep2 = shopPage.GetPriceProductStep2();
            Assert.AreEqual(actualPrice, actualPriceStep2);
            shopPage.ClickContinueButton();

            Assert.IsTrue(shopPage.IsPurchasePageDisplayed());
            shopPage.FillFormWithData(email, defaultText);
            var finalPrice = shopPage.GetFinalPrice();
            Assert.AreEqual(actualPrice, finalPrice);
            shopPage.ClickPurchase();
            Assert.IsTrue(shopPage.IsFinalPageDisplayed(), "Success");

            shopPage.ClickGoToCart();
            shopPage.Remove();

        }


    }
}

