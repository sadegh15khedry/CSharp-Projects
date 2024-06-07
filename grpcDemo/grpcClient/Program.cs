using Grpc.Net.Client;
using grpcServer;
namespace grpcClient;
public class Program
{
    public static async Task Main(string[] args)
    {
        var input = new HelloRequest { Name = "sadegh" };
        var channel = GrpcChannel.ForAddress("https://localhost:7042");
        var client = new Greeter.GreeterClient(channel);

        var replay = await client.SayHelloAsync(input);

        Console.WriteLine(replay.Message);
        Console.ReadLine();
    }
}