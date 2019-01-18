using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Pages01;
using Helpers;
using Tests01;


namespace Tests01
{
    [TestFixture]
    class RegistrationTest : BaseTest
    {
        private string usernameWrong = "***";
        private string emailWrong = "1111";
        private string usernameValid = "tes4sd66d25ds";
        private string emailValid = "merrychristmfsas946@gmail.com";
        private string urlRegistration = "/wp-login.php?action=register";
        private string expectedMessage = "Registration complete. Please check your email.";

        [Test]
        public void RegistrationPageTest()
        {
            var loginPageB = new LoginPageB();
            loginPageB.OpenLoginPage(loginPageUrl);
            var registrationPage = new RegistrationPage();
            Assert.IsTrue(registrationPage.IsRegistrationLinkDisplayed(), "Verification Registration link is displayed");
            registrationPage.ClickRegistrationLink();
            Assert.AreEqual(urlRegistration, new Uri(driver.Url).PathAndQuery);
        }

        [Test]
        public void RegistrationWrongTest()
        {
            var registrationPage = new RegistrationPage();
            registrationPage.OpenRegistrationPage(registrPageUrl);
            Assert.IsTrue(registrationPage.IsRegistrationFormDisplyed(), "Verification Regitration form  is displayed");
            Assert.IsTrue(registrationPage.IsRegisterBtnDisplyed(), "Verification Registration button is displayed");
            registrationPage.FillFormWrong(usernameWrong, emailWrong);
            registrationPage.ClickRegisterBtn();
            Assert.IsTrue(registrationPage.IsErrorDisplayed(), "Error message should be displayed");
        }

        [Test]
        public void RegistrationCorrectTest()
        {
            var registrationPage = new RegistrationPage();
            registrationPage.OpenRegistrationPage(registrPageUrl);
            Assert.IsTrue(registrationPage.IsRegistrationFormDisplyed(), "Verification Regitration form  is displayed");
            Assert.IsTrue(registrationPage.IsRegisterBtnDisplyed(), "Verification Registration button is displayed");
            registrationPage.FillFormCorrect(usernameValid, emailValid);
            registrationPage.ClickRegisterBtn();
            Assert.IsTrue(registrationPage.IsSuccessDisplayed(), "Success message should be displayed");
            var actualMessage = registrationPage.GetTextOfSuccessMessage();
            Assert.AreEqual(expectedMessage, actualMessage);

        }
    }
}
