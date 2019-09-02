from selenium import webdriver
import time

class AndroidUIKitCatalog:

    def __init__(self, driver):
        self.driver_ = driver;
        self.appXpath = "//android.widget.TextView[@content-desc='App']";
        self.activityXpath = "//android.widget.TextView[@content-desc='Activity']";

    def clickOnAppCategory(self):
        self.driver_.find_element_by_xpath(self.appXpath).click();

    def findActivityCategory(self):
        return self.driver_.find_element_by_xpath(self.activityXpath);
