<?php
use PHPUnit\Framework\TestCase;
include('Utils/Driver.php');
include('Utils/DesiredCapabilities.php');
include('Objects/AndroidApp.php');

class AndroidAppTest extends TestCase {
  public $driver_, $cap, $testApp;

  public function setUp() {
    $this->cap = GetAndroidAppDesiredCapability();
    $this->driver_ = CreateDriver($this->cap);
    $this->testApp = new ApiDemos($this->driver_);
  }

  public function test_ClickOnApp() {
    print "\n***** Should be able to click on 'App' category *****";
    $this->assertTrue($this->testApp->clickOnAppCategory());
  }

  public function tearDown() {
    QuitDriver($this->driver_);
  }
}
?>
