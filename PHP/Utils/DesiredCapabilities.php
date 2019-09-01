<?php
function GetAndroidWebDesiredCapability() {
  $cap = array(
  'sessionName'         =>  '[PHP] Android automation test session',
  'sessionDescription'  =>  'Testing android web using php',
  'deviceOrientation'   =>  'portrait',
  'browserName'         =>  'chrome',
  'platformName'        =>  'Android',
  'deviceName'          =>  '', //ex: Galaxy S7
  'udid'                =>  '' // ex: CB5A24NFS6
  );
  return $cap;
}

function GetAndroidAppDesiredCapability() {
  $cap = array(
  'sessionName'         =>  '[PHP]Android app automation test session',
  'sessionDescription'  =>  'Testing android app using php',
  'deviceOrientation'   =>  'portrait',
  'app'                 =>  'https://s3-ap-southeast-1.amazonaws.com/kobiton-devvn/apps-test/ApiDemos-debug.apk',
  'platformName'        =>  'Android',
  'deviceName'          =>  '', //ex: Galaxy S8
  'udid'                =>  '' //ex: CB5A24NFS6
  );
  return $cap;
}
?>
