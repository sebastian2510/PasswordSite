using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace PasswordSite.Data
{
    public class Password
    {
        static public string? GetPassword(string url)
        {
            RestClient client = new(url);
            RestRequest request = new();
            return JsonConvert.DeserializeObject<PasswordAPI>(client.Execute(request).Content).Data;   
        }

    }
    public class PasswordAPI
    {
        public string? Data { get; set; }
    }
}
