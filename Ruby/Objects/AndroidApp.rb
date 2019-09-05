require 'selenium-webdriver'
require_relative '../Utils/Driver'
require_relative '../Utils/Helpers'

class AndroidApp

  def initialize driver
    @driver = driver
    @appCategoryXpath = "//android.widget.TextView[@content-desc='App']"
    @activityCategoryXpath = "//android.widget.TextView[@content-desc='Activity']"
  end

  def findActivityCategory
    @driver.find_element(:xpath, @appCategoryXpath).click
    return @driver.find_element(:xpath, @activityCategoryXpath).text
  end

end
