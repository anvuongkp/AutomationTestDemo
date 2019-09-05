require 'selenium-webdriver'

def wait_for seconds
  Selenium::WebDriver::Wait.new(:timeout => seconds).until{yield}
end
