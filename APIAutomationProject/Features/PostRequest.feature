Feature: PostRequest


@tag1
Scenario: POST Request
	Given I have an endPoint api/users
	When I make post request using body
	Then Response status should be 201
	And Response body should contain created data