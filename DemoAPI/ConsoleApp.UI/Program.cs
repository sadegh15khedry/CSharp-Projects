namespace ConsoleApp.UI;

using Newtonsoft.Json.Linq;
using RestSharp;

public class Program
{
    static void Main(string[] args)
    {
        var client = new RestClient("https://jsonplaceholder.typicode.com/posts");
        var payload = new JObject();
        payload.Add("title", "this is title");
        payload.Add("body", "this is body");

        var request = new RestRequest();

        request.AddStringBody(payload.ToString(), DataFormat.Json);


        var resualt = client.GetAsync(request).Result;
        Console.WriteLine(resualt.Content.ToString());
    }
}