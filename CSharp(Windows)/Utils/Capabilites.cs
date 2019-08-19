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

    }
}
