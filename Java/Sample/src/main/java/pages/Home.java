package pages;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;

public class Home extends Base {
    By usernameId = By.id("username");
    By passwordId = By.id("password");
    By formXpath = By.xpath("//form[@name=\"login\"]");
    By messageXpath = By.xpath("//div[@id=\"flash\"]");
    String url = "http://the-internet.herokuapp.com/login";
    String username = "tomsmith";
    String password = "SuperSecretPassword!";
    int TIMEOUT = 10;

    public Home(WebDriver driver) {
        super(driver);
    }

    public void goToLoginPage() {
        goToAddress(url);
    }

    public void inputCredentials() {
        inputText(usernameId, username);
        inputText(passwordId, password);
    }

    public void submitLogin() {
        findElement(formXpath).submit();
    }

    public String getLoginMessage() {
        return waitForElement(messageXpath, TIMEOUT).getText();
    }
}
