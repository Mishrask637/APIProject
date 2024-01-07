Feature: DeletRequest


@tag1
Scenario: Delete Request
	Given I have an endPoint api/users/
	When I make and delete request with param 1
	Then Response status code is 204
	Then response should be in json format
