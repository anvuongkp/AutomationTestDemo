using System;
using OpenQA.Selenium.Remote;

namespace Appium.Utils
{
    public class Driver
    {
        private RemoteWebDriver driver;
        private const int TIMEOUT = 160 * 1000;
        private const int IMPLICIT_WAIT = 20 * 1000;
        public Driver() {}

        public RemoteWebDriver CreateWebDriver(DesiredCapabilities capability) {
            driver = new RemoteWebDriver(new Uri(Configuration.APPIUM_URL), capability, System.TimeSpan.FromMilliseconds(TIMEOUT));
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromMilliseconds(IMPLICIT_WAIT));
            return driver;
        }

    }
}
