# Python Web + App test on Windows with Android device


## Prerequisites
- Install Python: https://www.python.org/downloads/windows/

## Dependencies
- install selenium

`pip install selenium`

## Configurations
- Modify "Python/Utils/Environment.py" for Appium server URL, leave as default if run Appium server locally

- Change device's info("deviceName", "platformVersion", "udid") in "Python/Utils/DesiredCapabilities.py"

## Run test
- Open Windows command line, change to project's root folder which is Python

- Make sure Appium server has been started

- run android web test:
`python Testcases/AndroidWebTest.py`

- run android app test:
`python Testcases/AndroidAppTest.py`
