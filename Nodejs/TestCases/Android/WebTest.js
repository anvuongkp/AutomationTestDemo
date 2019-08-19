import 'babel-polyfill'
import 'colors'
import {assert} from 'chai'
import * as configs from '../../Utils/Capabilities'
import {createDriver, quitDriver} from '../../Utils/Driver'
import HerokuPage from '../../Objects/HerokuPage'

const desiredCap = configs.desiredCapabilitiesAndroidWeb
describe('android auto web test', () => {
  it('should login sussessfully', async () =>{
    const driver = await createDriver(desiredCap)
    const timeout = 60000
    const herokuPage = new HerokuPage(driver, timeout)
    await herokuPage.login()
    const expect = 'You logged into a secure area!\n×'
    const actual = await herokuPage.getMessage()
    assert.equal(actual, expect)
    await quitDriver(driver)
  })
})
