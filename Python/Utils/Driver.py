from selenium import webdriver
from selenium.webdriver.common.desired_capabilities import DesiredCapabilities
from selenium.webdriver.remote.remote_connection import RemoteConnection
from Environment import GetEnvironment

session_timeout = 30
wait_time = 20

def CreateDriver(self, desiredCapability):
    self.driver = webdriver.Remote(
        desired_capabilities = desiredCapability,
        command_executor = GetEnvironment()
    )
    self.driver.implicitly_wait(wait_time)
    return self.driver

def CleanUp(self):
    self.driver.quit()
