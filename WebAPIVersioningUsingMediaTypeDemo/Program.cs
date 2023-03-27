using Microsoft.AspNetCore.Mvc.Versioning;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddApiVersioning(x =>
{
    x.AssumeDefaultVersionWhenUnspecified = true;
    x.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    x.ReportApiVersions = true;
    x.ApiVersionReader = new MediaTypeApiVersionReader("version");
});

var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();

