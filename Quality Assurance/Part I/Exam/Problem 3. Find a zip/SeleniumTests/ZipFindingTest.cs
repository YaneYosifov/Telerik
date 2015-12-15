namespace SeleniumTests
{
    using System;
    using System.Text;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.Support.UI;

    [TestFixture]
    public class FindZip
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            this.driver = new FirefoxDriver();
            this.baseURL = "http://www.findazip.com";
            this.verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                this.driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }

            Assert.AreEqual(string.Empty, this.verificationErrors.ToString());
        }

        [Test]
        public void TheFindZipTest()
        {
            this.driver.Navigate().GoToUrl(this.baseURL + "/");
            this.driver.FindElement(By.LinkText("Cities Starting... Y...")).Click();
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                this.driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                this.driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = this.driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (this.acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }

                return alertText;
            }
            finally
            {
                this.acceptNextAlert = true;
            }
        }
    }
}
