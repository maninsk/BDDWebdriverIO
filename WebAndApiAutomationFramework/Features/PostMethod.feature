Feature: PostMethod

This test covers the post operation


Scenario: Authorized user able to add new pet
	Given the user gives pet data
	When user adds on pet information
	Then sucessful response should be received
	And the pet data should be added
