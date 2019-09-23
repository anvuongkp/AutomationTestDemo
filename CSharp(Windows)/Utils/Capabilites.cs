using OpenQA.Selenium.Remote;

namespace Appium.Utils
{
    public class Capabilities
    {
        private readonly DesiredCapabilities capabilities;
        public Capabilities() {
            capabilities = new DesiredCapabilities();
        }

        public DesiredCapabilities GetAndroidWebDesiredCapability() {
            capabilities.SetCapability("sessionName", "[C#] Android Web");
            capabilities.SetCapability("sessionDescription", "testing selenium web with c# on android device");
            capabilities.SetCapability("deviceOrientation", "portrait");
            capabilities.SetCapability("captureScreenshots", true);
            capabilities.SetCapability("browserName", "chrome");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("deviceName", Configuration.DEVICE_NAME);
            capabilities.SetCapability("platformVersion", Configuration.PLATFORM_VERSION);
            capabilities.SetCapability("udid", Configuration.DEVICE_UDID);
            return capabilities;
        }

        public DesiredCapabilities GetAndroidAppDesiredCapability()
        {
            capabilities.SetCapability("sessionName", "[C#] Android App");
            capabilities.SetCapability("sessionDescription", "This is an example for Android app testing");
            capabilities.SetCapability("deviceOrientation", "portrait");
            capabilities.SetCapability("captureScreenshots", true);
            capabilities.SetCapability("app", "https://s3-ap-southeast-1.amazonaws.com/kobiton-devvn/apps-test/demo/com.dozuki.ifixit.apk");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("deviceName", Configuration.DEVICE_NAME);
            capabilities.SetCapability("platformVersion", Configuration.PLATFORM_VERSION);
            capabilities.SetCapability("udid", Configuration.DEVICE_UDID);
            return capabilities;
        }
    }
}
