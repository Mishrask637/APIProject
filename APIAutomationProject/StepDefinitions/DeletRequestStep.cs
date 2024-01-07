using APIAutomationProject.Helper;
using NUnit.Framework;
using RestSharp;

namespace APIAutomationProject.StepDefinitions
{
    [Binding]
    public class DeletRequestStep
    {
        RestResponse response = null;

        [When(@"I make and delete request with param (.*)")]
        public void WhenIMakeAndDeleteRequestWithParam(int param)
        {
            RestHelper.createRequestUsingParam(param.ToString());
            response = RestHelper.createDeleteRequest();
        }

        [Then(@"Response status code is (.*)")]
        public void ThenResponseShouldHaveStatusCode(int statusCode)
        {
            Assert.That((int)response.StatusCode, Is.EqualTo(statusCode));
        }

        [Then(@"response should be in json format")]
        public void ThenResponseBodyShouldContainUpdatedData()
        {
            Console.WriteLine("Updated Data is {0}", response.Content);
        }
    }
}
