using System;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace Appium.Utils
{
    public class Driver
    {
        private const int TIMEOUT = 160 * 1000;
        public Driver() {}

        public RemoteWebDriver CreateWebDriver(DesiredCapabilities capability) {
            const int IMPLICIT_WAIT = 20 * 1000;
            RemoteWebDriver driver = new RemoteWebDriver(new Uri(Configuration.APPIUM_URL), capability, System.TimeSpan.FromMilliseconds(TIMEOUT));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(IMPLICIT_WAIT));
            return driver;
        }

        public AndroidDriver<AndroidElement> CreateAndroidDriver(DesiredCapabilities capability) {
            return new AndroidDriver<AndroidElement>(new Uri(Configuration.APPIUM_URL), capability, System.TimeSpan.FromMilliseconds(TIMEOUT));
        }

    }
}
