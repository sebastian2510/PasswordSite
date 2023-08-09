using Newtonsoft.Json;
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

            string content = client.Execute(request).Content ?? throw new Exception("Content is null");
            return JsonConvert.DeserializeObject<JokeAPI>(content).Joke;
        }
    }

    internal class JokeAPI
    {
        public string? Joke { get; set; }
    }

}
