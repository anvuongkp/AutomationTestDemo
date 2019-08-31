package com.sample;

public class Configs {

    static final String DRIVER = "webdriver.chrome.driver";
    static final String PATH = ""; // location of chromedriver.exe file
    public static void setChromeDriverPath() {
        System.setProperty(DRIVER, PATH);
    }
}
