require 'selenium-webdriver'
require_relative '../Utils/Driver'
require_relative '../Utils/Helpers'

class HerokuWeb
  def initialize driver
    @driver = driver
    @loginMsg = ''
    @url = 'https://the-internet.herokuapp.com/login'
    @username = 'tomsmith'
    @password = 'SuperSecretPassword!'
    @wrongUsername = 'test_username'
    @wrongPassword = 'test_password'
    @usernameId = 'username'
    @passwordId = 'password'
    @loginMessageId = 'flash'
    @btnLoginXpath = '//button[contains(.,"Login")]'
    @waitingTime = 20
    @pageTitle = 'the internet'
  end

  def login
    @driver.navigate.to @url
    wait_for(@waitingTime) {@driver.title.downcase.start_with? @pageTitle}
    @driver.find_element(:id, @usernameId).send_keys @username
    @driver.find_element(:id, @passwordId).send_keys @password
    @driver.find_element(:xpath, @btnLoginXpath).click
  end

  def emptyFieldValidation
    @driver.navigate.to @url
    @driver.find_element(:xpath, @btnLoginXpath).click
  end

  def loginWithWrongUserName
    @driver.navigate.to @url
    @driver.find_element(:id, @usernameId).send_keys @wrongUsername
    @driver.find_element(:id, @passwordId).send_keys @password
    @driver.find_element(:xpath, @btnLoginXpath).click
  end

  def loginWithWrongPassword
    @driver.navigate.to @url
    @driver.find_element(:id, @usernameId).send_keys @username
    @driver.find_element(:id, @passwordId).send_keys @wrongPassword
    @driver.find_element(:xpath, @btnLoginXpath).click
  end

  def getLoginMessage
    return @driver.find_element(:id, @loginMessageId).text
  end

end
