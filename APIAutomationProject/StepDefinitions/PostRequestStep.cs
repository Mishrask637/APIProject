using APIAutomationProject.Helper;
using APIAutomationProject.POJOClasses;
using NUnit.Framework;
using RestSharp;

namespace APIAutomationProject.StepDefinitions
{
    [Binding]
    public class PostRequestStep
    {
        RestResponse response = null;

        [Given(@"I have an endPoint (.*)")]
        public void GivenIHaveAnEndPoint(string endPoint)
        {
            RestHelper.createUrl(endPoint);
        }

        [When(@"I make post request using body")]
        public void WhenIMakePostRequest()
        {
            var userBody = new ReqResUser();
            userBody.name = "Suraj Mishra";
            userBody.job = "Technical Lead";
            RestHelper.createRequestUsingBody(userBody);
            response = RestHelper.createPOSTRequest();
        }

        [Then(@"Response status should be (.*)")]
        public void ThenResponseStatusShouldBe(int statusCode)
        {
            Assert.That((int)response.StatusCode, Is.EqualTo(statusCode));
        }

        [Then(@"Response body should contain created data")]
        public void ThenResponseBodyShouldContainCreatedData()
        {
            Console.WriteLine("Response Body is : {0}",response.Content);
        }
    }
}
