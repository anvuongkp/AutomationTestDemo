using System;
using Xunit;
using Appium.Models;
using Appium.Utils;

namespace Appium.Testcases
{
    public class AndroidAppTest
    {
        private iFixit appTest;
        private Capabilities capabilites;
        readonly Driver driver;
        private String categoryTitle;
        public AndroidAppTest()
        {
            capabilites = new Capabilities();
            driver = new Driver();
        }

        [Fact]
        public void SearchForCatagoryNameOnAndroidApp()
        {
            try
            {
                appTest = new iFixit(driver.CreateAndroidDriver(capabilites.GetAndroidAppDesiredCapability()));
                Console.WriteLine("#### should be able to search for 'Acura' on iFixit Android app\n");
                categoryTitle = "Acura";
                Assert.Contains(categoryTitle, appTest.GetCategoryTitle());
            }
            finally
            {
                if (appTest != null)
                {
                    appTest.CleanUp();
                }
            }
        }

    }
}
