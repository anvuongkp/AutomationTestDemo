require 'selenium-webdriver'
require 'test/unit'
require_relative '../Objects/AndroidApp'
require_relative '../Utils/Driver'
require_relative '../Utils/DesiredCapabilities'

class AndroidAppTest < Test::Unit::TestCase

  def setup
    @cap = getAndroidAppDesiredCapability
    @driver = CreateDriver @cap
    @testApp = AndroidApp.new @driver
    @expectedCategoryName = 'Activity'
  end

  def test_should_show_activity_category
    assert_equal @expectedCategoryName, @testApp.findActivityCategory
  end

  def teardown
    QuitDriver @driver
  end

end
