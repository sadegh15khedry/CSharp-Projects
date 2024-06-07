namespace WorkerServiceDemo;

public class Worker : BackgroundService
{
    private HttpClient client;
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    public override Task StartAsync(CancellationToken cancellationToken)
    {
        client = new HttpClient();
        return base.StartAsync(cancellationToken);
    }

    public override Task StopAsync(CancellationToken cancellationToken)
    {
        client.Dispose();
        return base.StopAsync(cancellationToken);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var result = await client.GetAsync("https://www.google.com");
            if (result.IsSuccessStatusCode == true)
            {
                _logger.LogInformation("google is up and status code is {StatusCode}", result.StatusCode);
            }
            else
            {
                _logger.LogInformation("google is down and status code is {StatusCode}", result.StatusCode);
            }

            await Task.Delay(3000, stoppingToken);
        }
    }
}
