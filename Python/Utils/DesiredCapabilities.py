
def GetAndroidWebDesiredCapability():
    capability = {}
    capability['sessionName'] = '[Python] Android Web'
    capability['sessionDescription'] = 'Web automation on android device using Python'
    capability['browserName'] = 'chrome'
    capability['platformName'] = 'Android'
    capability['deviceName'] = ''
    capability['platformVersion'] = ''
    capability['udid'] = ''
    return capability

def GetAndroidAppDesiredCapability():
    capability = {}
    capability['sessionName'] = '[Python] Android App'
    capability['sessionDescription'] = 'App automation on android device using Python'
    capability['app'] = 'https://s3-ap-southeast-1.amazonaws.com/kobiton-devvn/apps-test/ApiDemos-debug.apk'
    capability['platformName'] = 'Android'
    capability['deviceName'] = ''
    capability['platformVersion'] = ''
    capability['udid'] = ''
    return capability
