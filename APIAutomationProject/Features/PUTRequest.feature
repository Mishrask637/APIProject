Feature: PUTRequest


@tag1
Scenario: Put Request
	Given I have an endPoint api/users/
	When I make an put request for user 2 using body
	Then response should have status code 200
	And Response body should contain Updated data
