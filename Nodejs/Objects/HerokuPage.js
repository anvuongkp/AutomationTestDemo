import {waitForElement} from '../Utils/Helper'

const elements = {
  url: 'http://the-internet.herokuapp.com/login',
  usernameId: 'username',
  passwordId: 'password',
  username: 'tomsmith',
  password: 'SuperSecretPassword!',
  formXpath: '//form[@name="login"]',
  messageXpath: '//div[@id="flash"]'
}

export default class HerokuPage {
  constructor(driver, timeout) {
    this.driver_ = driver
    this.timeout_ = timeout
  }

  async login() {
    await this.driver_
      .get(elements.url)
      .waitForElementById(elements.usernameId, this.timeout_, 2000)
      .sendKeys(elements.username)
      .waitForElementById(elements.passwordId, this.timeout_, 2000)
      .sendKeys(elements.password)
      .waitForElementByXPath(elements.formXpath, this.timeout_, 2000)
      .submit()
  }

  async getMessage() {
    return await this.driver_
      .waitForElementByXPath(elements.messageXpath, this.timeout_, 2000)
      .text()
  }
}
