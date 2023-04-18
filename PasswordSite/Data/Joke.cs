using Newtonsoft.Json.Linq;
using RestSharp;

namespace PasswordSite.Data
{
    public class Joke
    {
        static public string GetJoke()
        {
            RestClient client = new RestClient("https://icanhazdadjoke.com/");
            RestRequest request = new RestRequest();
            request.AddHeader("Accept", "application/json");

            RestResponse response = client.Execute(request);
            dynamic content = JObject.Parse(response.Content);
            return content.joke;
        }
    }
}
