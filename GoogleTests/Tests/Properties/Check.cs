using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using OpenQA.Selenium;
using static Properties.ExtentR;
using static Properties.GetScreenshot;

namespace Properties
{
    public static class Check
    {
        private static IWebDriver driver;

        public static void Equals(string expectedResult, string actualResult, bool fail = false, string message = "Step failed")
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";

            try
            {
                Assert.AreEqual(expectedResult, actualResult);
            }
            catch (Exception ex)
            {

                if (fail)
                {
                    test.Log(LogStatus.Fatal, stackTrace + message);
                    Assert.Fail(message);
                    string screenShotPath = GetScreenshot.Capture(driver, "ScreenShotName");
                    test.Log(LogStatus.Fatal, "Snapshot below: " + test.AddScreenCapture(screenShotPath));
                }
                else
                {
                    test.Log(LogStatus.Fail, stackTrace + message);
                    string screenShotPath = GetScreenshot.Capture(driver, "ScreenShotName");
                    test.Log(LogStatus.Fatal, "Snapshot below: " + test.AddScreenCapture(screenShotPath));
                }
            }
        }

        public static void IsTrue(bool actualResult, bool fail = false, string message = "Step failed")
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";

            try
            {
                Assert.IsTrue(actualResult);
            }
            catch (Exception ex)
            {

                if (fail)
                {
                    test.Log(LogStatus.Fatal, stackTrace + message);
                    Assert.Fail(message);
                    string screenShotPath = GetScreenshot.Capture(driver, "ScreenShotName");
                    test.Log(LogStatus.Fatal, "Snapshot below: " + test.AddScreenCapture(screenShotPath));
                }
                else
                {
                    test.Log(LogStatus.Fail, stackTrace + message);
                    string screenShotPath = GetScreenshot.Capture(driver, "ScreenShotName");
                    test.Log(LogStatus.Fatal, "Snapshot below: " + test.AddScreenCapture(screenShotPath));
                }
            }
        }
    }
}
