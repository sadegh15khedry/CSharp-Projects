using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace DemoApi.IntegrartionTest;

public class HealthCheckTests : IClassFixture<WebApplicationFactory<Program>>
{

    private readonly HttpClient _httpClient;

    public HealthCheckTests(WebApplicationFactory<Program> factory)
    {
        _httpClient = factory.CreateClient();
    }

    [Fact]
    public async Task HealthCheck_ReturnOk()
    {
        var response = await _httpClient.GetAsync("/healthcheck");

        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

}

public class WebApplicationFactory<T1, T2>
{
}