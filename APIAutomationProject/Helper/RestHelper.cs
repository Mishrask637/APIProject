using RestSharp;

namespace APIAutomationProject.Helper
{
    public class RestHelper
    {
        public static RestClient restClient;
        public static RestRequest restRequest;
        public static string baseUrl = "https://reqres.in/";

        public static RestClient createUrl(string endPoint)
        {
            var url = Path.Combine(baseUrl, endPoint);
            Console.WriteLine("URL Formed is {0}",url);
            return restClient = new RestClient(url);
        }

        public static RestRequest createRequest()
        {
            restRequest = new RestRequest();
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static RestRequest createRequestUsingBody(Object body)
        {
            restRequest = new RestRequest();
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddBody(body);
            return restRequest;
        }

        public static RestRequest createRequestUsingBodyAndParam(Object body,string param)
        {
            restRequest = new RestRequest();
            restRequest.AddHeader("Accept", "application/json");
            restRequest.Resource = param;
            restRequest.AddBody(body);
            return restRequest;
        }

        public static RestRequest createRequestUsingParam(string parameter)
        {
            restRequest = new RestRequest();
            restRequest.Resource=parameter;
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static RestRequest createRequestUsingPathAndQueryParam(string pathParameter,string queryParam)
        {
            restRequest = new RestRequest();
            restRequest.Resource = pathParameter+"?id={queryParam}";
            restRequest.AddParameter("queryParam",queryParam,ParameterType.UrlSegment);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static RestResponse createGetRequest()
        {
            return restClient.Get(restRequest);
        }

        public static RestResponse createPOSTRequest()
        {
            return restClient.Post(restRequest);
        }

        public static RestResponse createPUTRequest()
        {
            return restClient.Put(restRequest);
        }

        public static RestResponse createDeleteRequest()
        {
            return restClient.Delete(restRequest);
        }

    }
}
