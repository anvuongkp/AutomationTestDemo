using OpenQA.Selenium.Remote;
using OpenQA.Selenium;
using Appium.Objects;

namespace Appium.Models
{
    public class HerokuPage: BasePage {
        private string testUrl = "http://the-internet.herokuapp.com/login";
        private string username = "tomsmith";
        private string password = "SuperSecretPassword!";
        readonly By messageXpath = By.XPath("//div[@id='flash']");
        readonly By buttonLoginXpath = By.XPath("//button[@class='radius']");
        readonly By usernameId = By.Id("username");
        readonly By passwordId = By.Id("password");
        readonly int TIMEOUT = 15;

        public HerokuPage(RemoteWebDriver driver) : base(driver){}
        
        public void LoginWithCorrectCredentials() {
            NavigateTo(testUrl);
            driver.FindElement(usernameId).SendKeys(username);
            driver.FindElement(passwordId).SendKeys(password);
            ClickOn(buttonLoginXpath);
        }

        public string GetLoginMessage() {
            return WaitUntilVisible(messageXpath, TIMEOUT).Text;
        }
    }
}
