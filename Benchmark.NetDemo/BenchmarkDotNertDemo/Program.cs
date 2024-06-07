namespace BenchmarkDotNetDemo;

using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
        var results = BenchmarkRunner.Run<Demo>();
    }
}




