using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Text;

namespace BenchmarkDotNetDemo;
[SimpleJob(RuntimeMoniker.Net50)]
[MemoryDiagnoser]
public class Demo
{
    [Benchmark(Baseline = true)]
    public string GetFullyStringNormally()
    {
        string output = "";
        for (int i = 0; i < 100000; i++)
        {
            output += i + " ";
        }
        return output;
    }

    [Benchmark]
    public string GetFullyStringNormallyWithStringBuilder()
    {
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < 100000; i++)
        {
            output.Append(i);
        }
        return (output.ToString());
    }
}
