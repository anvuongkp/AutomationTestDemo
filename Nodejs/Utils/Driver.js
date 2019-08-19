import 'babel-polyfill'
import wd from 'wd'
import {environment} from './Configurations'

export async function quitDriver(driver) {
  try {
    await driver.quit()
  }
  catch (err) {
    console.log('failed to quit driver', err)
  }
}

export async function createDriver(desiredCapabilities) {
  const driver = await wd.promiseChainRemote(environment)
  try {
    await driver.init(desiredCapabilities)
    await driver.setImplicitWaitTimeout(8000);
  }
  catch (error) {
    if (error.data) {
      console.log('failed to create driver', error)
    }
    throw error
  }
  return driver
}
