require 'selenium-webdriver'
require 'test/unit'
require_relative '../Objects/HerokuWeb'
require_relative '../Utils/Driver'
require_relative '../Utils/DesiredCapabilities'

class AndroidWebTest < Test::Unit::TestCase
  def setup
    @cap = getAndroidWebDesiredCapability
    @driver = CreateDriver @cap
    @testPage = HerokuWeb.new @driver
    @loginMsg = 'You logged into a secure area'
    @failMsg = 'Login message is not matched'
  end

  def test_should_login_successfully
    @testPage.login
    assert_includes @testPage.getLoginMessage, @loginMsg, @failMsg
  end

  def teardown
    QuitDriver @driver
  end

end
