require 'selenium-webdriver'
require_relative 'Environments'

def CreateDriver cap
  driver_ = Selenium::WebDriver.for(
    :remote,
    :url => getLocalServer,
    :desired_capabilities => cap
  )
  driver_.manage.timeouts.implicit_wait = 20
  return driver_
end

def QuitDriver driver
  driver.quit
end
