require 'selenium-webdriver'

def CreateDriver()
  Selenium::WebDriver::Chrome::Service.driver_path = "C:\\Users\\chromedriver.exe"
  driver_ = Selenium::WebDriver.for :chrome
  driver_.manage.timeouts.implicit_wait = 20
  return driver_
end

def QuitDriver driver
  driver.quit
end
