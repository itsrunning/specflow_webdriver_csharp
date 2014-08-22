Feature: Verify User Creation

Scenario: User table lists all users
Given I have a user called deepak
Given I have a user called dummy
When I navigate to all users page
Then I see the following users
| name |
| deepak|
| dummy |


@MANUAL
Ser:

