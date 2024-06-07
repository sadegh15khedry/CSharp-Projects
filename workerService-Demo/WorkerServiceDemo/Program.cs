using WorkerServiceDemo;
using Serilog;
using Serilog.Events;

namespace WorkerServiceDemo;
public class Program
{
    public static async Task Main(string[] args)
    {
        var logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Warning)
            .Enrich.FromLogContext()
            .WriteTo.File(@"WorkerServiceDemo\Log.txt")
            .CreateLogger();

        try
        {
            Log.Information("starting up the service");
            CreateHostBuilder(args).Build().Run();
            return;
        }
        catch (Exception ex)
        {

            Log.Fatal(ex, "there was a problem starting the service");
            return;
        }
        finally
        {
            Log.CloseAndFlush();
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>();
                })
            .UseSerilog();
        }



        // .Build();

        //     await host.RunAsync();


    }
}