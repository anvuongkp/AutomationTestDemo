<?php
use PHPUnit\Framework\TestCase;
include('Utils/Driver.php');
include('Utils/DesiredCapabilities.php');
include('Objects/HerokuWeb.php');

class AndroidWebTest extends TestCase {
  public $cap, $driver_, $testPage, $successMsg;

  public function setUp() {
    $this->caps = GetAndroidWebDesiredCapability();
    $this->driver_ = CreateDriver($this->caps);
    $this->testPage = new HerokuWeb($this->driver_);
    $this->successMsg = "You logged into a secure area!";
  }

  public function test_login() {
    print "\n ***** should run test successfully with correct username and password *****";
    $this->assertContains($this->successMsg, $this->testPage->getLoginMessage());
  }

  public function tearDown() {
    QuitDriver($this->driver_);
  }
}
?>
