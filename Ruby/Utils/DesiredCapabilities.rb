def getAndroidWebDesiredCapability
  return caps = {
    sessionName:         '[Ruby] Android web automation',
    sessionDescription:  'Testing android web using Ruby',
    browserName:         'chrome',
    platformName:        'Android',
    deviceName:          '', # <-- change here
    platformVersion:     '', # <-- change here
    udid:                ''  # <-- change here
  }
end

def getAndroidAppDesiredCapability
  return caps = {
    sessionName:        '[Ruby] Android app automation',
    sessionDescription: 'Testing android app using Ruby',
    app:                'https://s3-ap-southeast-1.amazonaws.com/kobiton-devvn/apps-test/ApiDemos-debug.apk',
    platformName:       'Android',
    deviceName:         '', # <-- change here
    platformVersion:    '', # <-- change here
    udid:               ''  # <-- change here
  }
end
