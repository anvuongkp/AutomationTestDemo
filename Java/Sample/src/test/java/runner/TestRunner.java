package runner;

import io.cucumber.junit.Cucumber;
import io.cucumber.junit.CucumberOptions;
import org.junit.runner.RunWith;

@RunWith(Cucumber.class)

@CucumberOptions(
        features = {"./features/HerokuLogin.feature"},
        glue = {"definitions"},
        plugin = { "de.monochromata.cucumber.report.PrettyReports:target/cucumber" }
        )

public class TestRunner {
}
