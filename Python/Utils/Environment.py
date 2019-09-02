
def GetEnvironment():
    '''local appium environment'''
    protocol = 'http'
    host = '127.0.0.1'
    port = 4723

    return "{}://{}:{}/wd/hub".format(
        protocol, host, port
    )
