<?php
use Facebook\WebDriver;
use Facebook\WebDriver\WebDriverBy;

class ApiDemos {
  private $driver_, $appCategoryXpath;

  function __construct($driver) {
    $this->driver_ = $driver;
    $this->appCategoryXpath = "//android.widget.TextView[@content-desc='App']";
  }

  public function clickOnAppCategory() {
    try {
      $this->driver_->findElement(WebDriverBy::xpath($this->appCategoryXpath))->click();
      return true;
    }
    catch(Exception $ex){
      echo "ERROR: ", $ex->getMessage(), "\n";
      return false;
    }
  }
}
?>
