Feature: Heroku Login

  Scenario: Successful login message should appear after logging in
    Given I launch chrome web browser
    When I navigate to Heroku login page
    And I enter correct username and password
    And I click on submit button
    Then I see text: "You're login to secured area"
    And Close browser
