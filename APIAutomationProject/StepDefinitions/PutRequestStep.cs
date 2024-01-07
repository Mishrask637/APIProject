using APIAutomationProject.Helper;
using APIAutomationProject.POJOClasses;
using NUnit.Framework;
using RestSharp;

namespace APIAutomationProject.StepDefinitions
{
    [Binding]
    public class PutRequestStep
    {
        RestResponse response;

        [When(@"I make an put request for user (.*) using body")]
        public void WhenIMakeAnPutRequestForUserUsingBody(int user)
        {
            var updatedBody = new ReqResUser();
            updatedBody.name = "Namrata Mishra";
            updatedBody.job = "Manager";
            RestHelper.createRequestUsingBodyAndParam(updatedBody,user.ToString());
            response = RestHelper.createPUTRequest();
        }

        [Then(@"response should have status code (.*)")]
        public void ThenResponseShouldHaveStatusCode(int statusCode)
        {   
            Assert.That((int)response.StatusCode, Is.EqualTo(statusCode));
        }

        [Then(@"Response body should contain Updated data")]
        public void ThenResponseBodyShouldContainUpdatedData()
        {
            Console.WriteLine("Updated Data is {0}",response.Content);
        }


    }
}
