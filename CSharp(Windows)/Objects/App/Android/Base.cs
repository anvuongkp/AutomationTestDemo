using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace Appium.Objects
{
    public class Base
    {
        public AndroidDriver<AndroidElement> driver;

        public Base(AndroidDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        public AndroidElement WaitUntilVisible(By by, int waitFor) {
            return (AndroidElement)new WebDriverWait(driver, TimeSpan.FromSeconds(waitFor))
                .Until(ExpectedConditions.ElementIsVisible(by));
        }

        public void CleanUp() => driver.Dispose();
    }
}
