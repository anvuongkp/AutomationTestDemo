
from selenium import webdriver
import unittest
import sys
sys.path.append('Utils')
from Driver import *
from DesiredCapabilities import GetAndroidAppDesiredCapability
sys.path.append('Objects')
import AndroidUIKitCatalog

class AndroidAppTest(unittest.TestCase):

    @classmethod
    def setUpClass(cls):
        cls.driver = CreateDriver(cls, GetAndroidAppDesiredCapability());
        cls.testApp = AndroidUIKitCatalog.AndroidUIKitCatalog(cls.driver);

    def test_findActivityCategory(self):
        print ("should show 'Activity' category");
        self.testApp.clickOnAppCategory();
        self.assertTrue(self.testApp.findActivityCategory())

    @classmethod
    def tearDownClass(cls):
        CleanUp(cls)

if __name__ == '__main__':
    suite = unittest.TestLoader().loadTestsFromTestCase(AndroidAppTest)
    isSuccess = unittest.TextTestRunner(verbosity=2).run(suite).wasSuccessful()
    sys.exit(not isSuccess)
