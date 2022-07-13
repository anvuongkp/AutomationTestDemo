# Ruby Web Test On Desktop

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
- Download chromedriver.exe binary file then store in C:\Users

## Run Tests
- Open Windows command line, change to project root directory which is RubyWeb

- Run web test:

`ruby Testcases/WebTest.rb`
