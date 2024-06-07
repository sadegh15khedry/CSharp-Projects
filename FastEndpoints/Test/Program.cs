using FastEndpoints;


var builder = WebApplication.CreateBuilder();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle


builder.Services.AddFastEndpoints();

var app = builder.Build();


app.UseFastEndpoints();

app.UseAuthorization();

app.Run();
