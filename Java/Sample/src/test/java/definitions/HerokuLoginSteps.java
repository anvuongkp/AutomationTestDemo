package definitions;

import com.sample.Drivers;
import io.cucumber.java.en.And;
import io.cucumber.java.en.Given;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;
import org.junit.Assert;
import org.openqa.selenium.WebDriver;
import pages.Home;

public class HerokuLoginSteps {
    WebDriver driver;
    Drivers chrome;
    Home loginPage;
    @Given("I launch chrome web browser")
    public void i_launch_chrome_web_browser() {
        chrome = new Drivers();
        driver = chrome.createChromeDriver();
    }

    @When("I navigate to Heroku login page")
    public void i_navigate_to_Heroku_login_page() {
        loginPage = new Home(driver);
        loginPage.goToLoginPage();
    }

    @And("I enter correct username and password")
    public void i_enter_correct_username_and_password() {
        loginPage.inputCredentials();
    }

    @And("I click on submit button")
    public void i_click_on_submit_button() {
        loginPage.submitLogin();
    }

    @Then("I see text: {string}")
    public void i_see_text(String string) {
        String actual = loginPage.getLoginMessage();
        String expect = "secure area";
        Assert.assertTrue(actual.contains(expect));
    }

    @And("Close browser")
    public void close_browser() {
        chrome.quitDriver();
    }
}
