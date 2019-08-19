const DEFAULT_TIMEOUT = 5000

export function waitForElement(locator, timeout) {
  const timeout_ = timeout || DEFAULT_TIMEOUT
  return this.wait(until.elementLocated(locator), timeout_)
}

export function waitForElementVisible(locator, timeout) {
  const timeout_ = timeout || DEFAULT_TIMEOUT
  const element = this.wait(until.elementLocated(locator), timeout_)
  return this.wait(new until.WebElementCondition('wait for element to be visible: ' + locator, () => {
    return element.isDisplayed().then(state => state ? element : null)
  }))
}
