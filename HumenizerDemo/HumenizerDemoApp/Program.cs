using Humanizer;

string test = "this is my SenTence. how do You Do think it Went?";

Console.WriteLine(test.Transform(To.LowerCase));
Console.WriteLine(test.Truncate(10));