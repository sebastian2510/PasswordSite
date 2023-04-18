using RestSharp;
using Newtonsoft.Json.Linq;


namespace PasswordSite.Data
{
    public class Password
    {
        static public string GetPassword(string url)
        {
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest();
            RestResponse response = client.Execute(request);
            dynamic content = JObject.Parse(response.Content);

            return content.data;
        }
    }
}
