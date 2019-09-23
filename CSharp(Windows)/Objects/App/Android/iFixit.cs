using System;
using Appium.Objects;
using Appium.Utils;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;

namespace Appium.Models
{
    public class iFixit: Base
    {
        private By browseDevicesXpath = By.XPath("//*[@text='Browse Devices']");
        private By carTruckXpath = By.XPath("//*[@text='Car and Truck']");
        private By acuraXpath = By.XPath("//*[@text='Acura']");
        private By acuraText = By.XPath("//*[@resource-id='com.dozuki.ifixit:id/topic_title' and @index=1]");
        private int WAIT_TIME = 20;
        public iFixit(AndroidDriver<AndroidElement> driver): base(driver){}

        public String GetCategoryTitle()
        {
            /*
              * Steps:
              * 1. Click on "Car and Truck" Categories on Homepage
              * 2. Click on "Acura" Categories
              *
              * Expected:
              * General Information is "Acura".
            */
            WaitUntilVisible(browseDevicesXpath, WAIT_TIME).Click();
            WaitUntilVisible(carTruckXpath, WAIT_TIME).Click();
            WaitUntilVisible(acuraXpath, WAIT_TIME).Click();
            string categoryTitle = WaitUntilVisible(acuraText, WAIT_TIME).Text;
            return categoryTitle;
        }

    }
}
