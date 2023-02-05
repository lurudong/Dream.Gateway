var builder = WebApplication.CreateBuilder(args);
builder.Services.AddReverseProxy().LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
var app = builder.Build();
app.UseRouting();
// Register the reverse proxy routes

app.Urls.Add("http://localhost:5236");
app.MapReverseProxy();
app.Run();
