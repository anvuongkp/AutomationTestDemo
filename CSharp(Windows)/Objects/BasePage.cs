using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace Appium.Objects
{
    public class BasePage
    {
        public RemoteWebDriver driver;

        public BasePage(RemoteWebDriver driver) {
            this.driver = driver;
        }

        public IWebElement WaitUntilVisible(By by, int timeout) {
            if (timeout > 0)
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            return driver.FindElement(by);
        }

        public void NavigateTo(string url) {
            driver.Navigate().GoToUrl(url);
        }

        public void ClickOn(By element) {
            driver.FindElement(element).Click();
        }

        public string GetPageTitle() {
            return driver.Title;
        }

        public void CleanUp() => driver.Dispose();
    }
}
