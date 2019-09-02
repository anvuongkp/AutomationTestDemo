from selenium import webdriver

class Heroku:

    def __init__(self, driver):
        self.driver_ = driver ;
        self.testUrl = "http://the-internet.Herokuapp.com/login";
        self.testLoginFormXpath = "//form[@name='login']";
        self.testUsernameId = "username";
        self.testPasswordId = "password";
        self.testMessageId = "flash";
        self.invalidUsernameMsg = "Your username is invalid!";
        self.invalidPasswordMsg = "Your password is invalid!";
        self.successMsg = "You logged into a secure area!";
        self.invalidUsername = "foo";
        self.username = "tomsmith";
        self.invalidPassword = "SuperSecretPassword";
        self.password = "SuperSecretPassword!";
        self.page_load_time_out = 20;

    def login(self, username, password):
        self.driver_.set_page_load_timeout(self.page_load_time_out);
        self.driver_.get(self.testUrl);
        self.driver_.find_element_by_id(self.testUsernameId).send_keys(username)
        self.driver_.find_element_by_id(self.testPasswordId).send_keys(password)
        self.driver_.find_element_by_xpath(self.testLoginFormXpath).submit()

    def getMessage(self):
        return self.driver_.find_element_by_id(self.testMessageId).text

    def getInvalidUsernameMsg(self):
      return self.invalidUsernameMsg

    def getInvalidPasswordMsg(self):
      return self.invalidPasswordMsg

    def getSuccessMsg(self):
      return self.successMsg

    def getInvalidUsername(self):
      return self.invalidUsername

    def getUsername(self):
      return self.username

    def getInvalidPassword(self):
      return self.invalidPassword

    def getPassword(self):
      return self.password
