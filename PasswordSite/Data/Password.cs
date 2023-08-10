using RestSharp;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace PasswordSite.Data
{
    public class Password
    {
        public static string GetPassword(bool numbers, bool chars, bool caps, int length)
        {
            RestClient client = new("https://passwordinator.onrender.com/");
            RestRequest request = new();
            request.AddHeader("num", numbers);
            request.AddHeader("char", chars);
            request.AddHeader("caps", caps);
            request.AddHeader("len", length);
            RestResponse test = client.Execute(request);
            string content = test.Content;
            return JsonConvert.DeserializeObject<PasswordAPI>(content).Data; // The JsonConvert could/should be a different function, but whatever
        }
    }
    public class PasswordAPI
    {
        public string? Data { get; set; }
    }
}