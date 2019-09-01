<?php
use Facebook\WebDriver\Remote\RemoteWebDriver;
include('Environments.php');

function CreateDriver($desiredCapability)
{
  $driver_ = RemoteWebDriver::create(
    getLocalServer(),
    $desiredCapability,
    $connection_timeout_in_ms = 1200000,
    $request_timeout_in_ms = 1200000);
  $driver_->manage()->timeouts()->implicitlyWait(10); //seconds
  return $driver_;
}

function QuitDriver($driver){
  if($driver) {
    $driver->quit();
  }
}
?>
