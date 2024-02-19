

namespace WebAndApiAutomationFramework.PageObjects
{
    using System;
    using System.Configuration;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class BasePage
    {
        protected WebDriverWait wait;
        private IWebDriver _driver;

        public void WaitAndClick(IWebElement element)
        {
            //wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }

        public void GoToSite()
        {
            _driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
        }

        public WebDriverWait Wait()
        {
            return new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
        }
    }
}
