# Ruby Automation Web + App Test On Android

## Prerequisites
- Ruby should be installed on Windows system

## Libs Installation
- Update latest version RubyGems
`gem update --system` -> update latest RubyGems

- Install Bundler to manage ruby application's gem (Bundler provides a consistent environment for Ruby projects by tracking and installing the exact gems and versions that are needed)
`gem install bundler`

`bundler init`

- Add following lines to Gemfile

`
gem 'selenium-webdriver'
gem 'test-unit'
`
- Install packages using bundler

`bundler install`

## Configurations
- Modify "Ruby/Utils/Environments.rb" for Appium server URL, leave default if running Appium server locally

- Change device's info (deviceName, platformVersion, udid) in "Rub/Utils/DesiredCapabilities.rb" to match your testing Android device

## Run Tests
- Open Windows command line, change to project root directory which is Ruby

- Appium server should be started

- Run web test:

`ruby Testcases/AndroidWebTest.rb`

- Run app test:

`ruby Testcases/AndroidAppTest.rb`
