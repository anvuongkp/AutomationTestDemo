package com.sample;

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class Drivers {
    WebDriver driver;

    public WebDriver createChromeDriver() {
        Configs.setChromeDriverPath();
        driver = new ChromeDriver();
        return driver;
    }

    public void quitDriver() {
        try {
            if (driver != null)
                driver.quit();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

}
