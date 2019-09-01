<?php
use Facebook\WebDriver\Remote\RemoteWebDriver;
use Facebook\WebDriver\WebDriverBy;
use Facebook\WebDriver\WebDriverExpectedCondition;

class HerokuWeb {
  private $driver_, $loginMsg, $url, $username, $password, $usernameId, $passwordId ,$loginMessageId, $formXpath;

  function __construct($driver) {
    $this->driver_ = $driver;
    $this->loginMsg = "";
    $this->url = "https://the-internet.herokuapp.com/login";
    $this->username = "tomsmith";
    $this->password = "SuperSecretPassword!";
    $this->usernameId = "username";
    $this->passwordId = "password";
    $this->loginMessageId = "flash";
    $this->formXpath = "//form[@name='login']";
  }

  private function login() {
    $this->driver_->get($this->url);
    $elementUsername = $this->driver_->findElement(WebDriverBy::id($this->usernameId));
    $this->waitUntilVisible($elementUsername);
    $elementUsername->sendKeys($this->username);

    $elementPassword = $this->driver_->findElement(WebDriverBy::id($this->passwordId));
    $this->waitUntilVisible($elementPassword);
    $elementPassword->sendKeys($this->password);

    $elementForm = $this->driver_->findElement(WebDriverBy::xpath($this->formXpath));
    $this->waitUntilVisible($elementForm);
    $elementForm->submit();
  }

  public function getLoginMessage() {
    $this->login();
    $elementLoginMsg = $this->driver_->findElement(WebDriverBy::id($this->loginMessageId));
    $this->waitUntilVisible($elementLoginMsg);
    return $elementLoginMsg->getText();
  }

  private function waitUntilVisible($element) {
    // Default wait() (= 30 sec)
    // Wait for at most 10s and retry every 500ms if it the title is not correct.
    $this->driver_->wait(10, 500)->until(WebDriverExpectedCondition::visibilityOf($element));
  }
}
?>
