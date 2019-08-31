package pages;

import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.ui.ExpectedConditions;
import org.openqa.selenium.support.ui.WebDriverWait;

public class Base {
    WebDriver driver;

    public Base(WebDriver driver) {
        this.driver = driver;
    }

    public void goToAddress(String url) {
        driver.get(url);
    }

    public WebElement findElement(By by) {
        return  driver.findElement(by);
    }

    public void inputText(By by, String value) {
        driver.findElement(by).sendKeys(value);
    }

    public WebElement waitForElement(By by, int timeout){
        WebDriverWait wait = new WebDriverWait(driver, timeout);
        return wait.until(ExpectedConditions.visibilityOfElementLocated(by));
    }

}
