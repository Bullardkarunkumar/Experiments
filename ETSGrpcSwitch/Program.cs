using Grpc.Core;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting.Server;
using ETSGrpcSwitch.Services;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();

//add CORS
builder.Services.AddCors(o => o.AddPolicy("AllowAll", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader()
           .WithExposedHeaders("Grpc-Status", "Grpc-Message", "Grpc-Encoding", "Grpc-Accept-Encoding");
}));

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<TemSwitchService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<TemSwitchService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.UseRouting();

// must be added after UseRouting and before UseEndpoints 
app.UseGrpcWeb();
app.UseCors();

app.UseEndpoints(endpoints =>
{
    // map to and register the gRPC service
    endpoints.MapGrpcService<TemSwitchService>().EnableGrpcWeb().RequireCors("AllowAll"); ;
    endpoints.MapRazorPages();
    endpoints.MapControllers();
    endpoints.MapFallbackToFile("index.html");
});

Server server = new Server
{
    Services = { ETSGrpcSwitch.TemSwitch.BindService(new TemSwitchService()) },
    Ports = { new ServerPort("localhost", 30051, ServerCredentials.Insecure) }
};
server.Start();

app.Run();


