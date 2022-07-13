require "selenium-webdriver"
require 'test/unit'
require_relative '../Objects/HerokuWeb'
require_relative '../Utils/Driver'

class WebTest < Test::Unit::TestCase
  def setup
    @driver = CreateDriver()
    @testPage = HerokuWeb.new @driver
    @loginMsg = 'You logged into a secure area'
    @failMsg = 'Login message is not matched'
    @warningUsernameMsg = 'Your username is invalid!'
    @failUsernameMsg = 'Empty username is not allowed'
    @warningPasswordMsg = 'Your password is invalid!'
    @failPasswordMsg = 'Empty password is not allowed'
  end

  def test_should_fail_with_empty_credentials
    @testPage.emptyFieldValidation
    assert_includes @testPage.getLoginMessage, @warningUsernameMsg, @failUsernameMsg
  end

  def test_should_fail_with_wrong_username
    @testPage.loginWithWrongUserName
    assert_includes @testPage.getLoginMessage, @warningUsernameMsg, @failUsernameMsg
  end

  def test_should_fail_with_wrong_password
    @testPage.loginWithWrongPassword
    assert_includes @testPage.getLoginMessage, @warningPasswordMsg, @failPasswordMsg
  end

  def test_should_login_successfully
    @testPage.login
    assert_includes @testPage.getLoginMessage, @loginMsg, @failMsg
  end

  def teardown
    QuitDriver @driver
  end

end
