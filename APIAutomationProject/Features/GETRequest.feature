Feature: Api Automation feature

@mytag
Scenario: Test API using code
	Given I have a end point api/users?page=2
	When I make a GET request
	Then The response status code is 200
	And response is in json format



Scenario: Test API using parameters
	Given I have a end point api/users/
	When I make a GET request passing pathParam 2
	Then The response status code is 200
	And response is in json format



Scenario Outline: Test API using parameters using outlline
	Given I have a end point api/users/
	When I make a GET request passing pathParam <PathParam>
	Then The response status code is 200
	And response is in json format

	Examples: 
	| PathParam |
	|     3     |



Scenario Outline: Test API using parameters using pathParam and queryParam
	Given I have a end point api/users/
	When I make a GET request by passing pathParam <PathParam> and queryParam <QueryParam>
	Then The response status code is 200
	And response is in json format

	Examples: 
	| PathParam | QueryParam |
	| 3         |   1        |