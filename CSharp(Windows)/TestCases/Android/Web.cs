using System;
using Xunit;
using Appium.Models;
using Appium.Utils;

namespace Appium.Testcases
{
    public class WebTest
    {
        readonly HerokuPage testPage;
        readonly Driver driver;
        private readonly Capabilities capabilities;

        public WebTest() {
            capabilities = new Capabilities();
            driver = new Driver();
            testPage = new HerokuPage(driver.CreateWebDriver(capabilities.GetAndroidWebDesiredCapability()));
        }
        
        [Fact]
        public void LoginHerokuWebsiteTest() {
            try {
                Console.WriteLine("#### Should be able to login using correct credentials ####\n");
                string expected = "You logged into a secure area";
                testPage.LoginWithCorrectCredentials();
                string actual = testPage.GetLoginMessage();
                Assert.Contains(expected, actual);
            }
            finally {
                if (testPage != null) testPage.CleanUp();
            }
        }

    }
}
