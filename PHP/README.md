# PHP Web + App Test On Windows With Android Devices


## Prerequisites
- Install PHP: https://windows.php.net/download/

- Install Composer: https://getcomposer.org/download/


## Libraries Installation
- open windows command line, go to PHP root directory

- install php client from facebook to connect with Selenium

`composer require facebook/webdriver`

- install testing framework for assertions action:

`composer require phpunit/phpunit-selenium`

notes:
- composer.json file should now contain below lines:
`
{
    "require": {
        "facebook/webdriver": "^1.7",
        "phpunit/phpunit-selenium": "^7.0"
    }
}
`
- if extra libraries required or need to be removed, update them in composer.json file then run:

`composer update`

## Configuration
- Modify "PHP/Utils/Environments.php" file for Appium's server URL or leave default if run Appium locally

- Change "PHP/Utils/DesiredCapabilities.php" file to match your device's info

## Run the test
- Appium server should be running, if run Appium server locally, please start it now

- Open Windows command line, change to project root folder PHP

- run web test files (AndroidWebTest.php)

`\vendor\bin\phpunit Testcases\AndroidWebTest`

- run app test files (AndroidAppTest.php)

`\vendor\bin\phpunit Testcases\AndroidAppTest`
