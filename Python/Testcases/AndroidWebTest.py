
from selenium import webdriver
import unittest
import sys
sys.path.append('Utils')
from Driver import *
from DesiredCapabilities import GetAndroidWebDesiredCapability
sys.path.append('Objects')
import Heroku

class AndroidWebTest(unittest.TestCase):

    @classmethod
    def setUpClass(cls):
        cls.driver = CreateDriver(cls, GetAndroidWebDesiredCapability())
        cls.testPage = Heroku.Heroku(cls.driver)

    def test_inputWrongUsername(self):
        self.testPage.login(self.testPage.getInvalidUsername(), self.testPage.getPassword())
        self.assertTrue(self.testPage.getInvalidUsernameMsg() in self.testPage.getMessage())

    def test_inputWrongPassword(self):
        self.testPage.login(self.testPage.getUsername(), self.testPage.getInvalidPassword())
        self.assertTrue(self.testPage.getInvalidPasswordMsg() in self.testPage.getMessage())

    def test_loginSuccessfully(self):
        self.testPage.login(self.testPage.getUsername(), self.testPage.getPassword())
        self.assertTrue(self.testPage.getSuccessMsg() in self.testPage.getMessage())

    @classmethod
    def tearDownClass(cls):
        CleanUp(cls)

if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(AndroidWebTest)
    isSuccess = unittest.TextTestRunner(verbosity=2).run(suite).wasSuccessful()
    sys.exit(not isSuccess)
