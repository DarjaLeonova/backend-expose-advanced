var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/hello", () => "Hello, EDP!");
app.MapMethods("/api/hello", new[] { "HEAD" }, () => Results.Ok());

app.Run();
