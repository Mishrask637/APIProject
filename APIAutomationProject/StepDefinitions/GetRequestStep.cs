using APIAutomationProject.Helper;
using NUnit.Framework;
using RestSharp;

namespace APIAutomationProject.StepDefinitions
{
    [Binding]
    public sealed class GetRequestStep
    {
        RestResponse response;

        [Given("I have a end point (.*)")]
        public void IHaveAnEndPoint(string endPoint)
        {
            Console.WriteLine("End point is "+endPoint);
            RestHelper.createUrl(endPoint);   
        }

        [When("I make a GET request")]
        public void IMakeAGetRequest()
        {
            RestHelper.createRequest();
            response = RestHelper.createGetRequest();
        }

        [When("I make a GET request passing pathParam (.*)")]
        public void IMakeAGetRequestPassingParam(string pathParam)
        {
            RestHelper.createRequestUsingParam(pathParam);
            response = RestHelper.createGetRequest();
        }

        [When("I make a GET request by passing pathParam (.*) and queryParam (.*)")]
        public void getRequestUsingPathAndQueryParam(string pathParam,string queryParam)
        {
            RestHelper.createRequestUsingPathAndQueryParam(pathParam,queryParam);
            response = RestHelper.createGetRequest();
        }

        [Then("The response status code is (.*)")]
        public void TheResponseStatusCodeIs(int statusCode)
        {
            Console.WriteLine("Response Status Code is : {0}", (int)response.StatusCode);
            Console.WriteLine("Response is : {0}",response.Content);
            Assert.That((int)response.StatusCode, Is.EqualTo(statusCode));
        }

        [Then("response is in json format")]
        public void ResponseIsInJsonFormat()
        {
            Assert.That(response.ContentType, Is.EqualTo("application/json"));
        }
    }
}
