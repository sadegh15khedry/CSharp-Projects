using Flurl;
using Flurl.ConsoleApp.UI;
using Flurl.Http;
var url = "https://jsonplaceholder.typicode.com/".AppendPathSegment("posts");


var results = await url.GetAsync();

var posts = await results.GetJsonAsync<IEnumerable<Post>>();


//Console.WriteLine(results.ToString());

Console.WriteLine(posts.Count());


