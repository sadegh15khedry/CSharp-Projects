using FastEndpoints;

namespace Test;

public class Class : EndpointWithoutRequest
{
    public override void Configure()
    {
        Verbs(Http.GET);
        Routes("example");
        AllowAnonymous(Http.GET);
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        await SendAsync(new
        {
            message = "Hello world"
        }, cancellation: ct);
    }
}
