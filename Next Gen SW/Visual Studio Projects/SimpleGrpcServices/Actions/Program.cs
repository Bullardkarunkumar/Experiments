using Actions.PositionerIterator;
using Actions.MeasureIterator;
using Actions.DataStore;
using Actions.PositionerIterator.Services;
using Actions.MeasureIterator.Services;
using Equipment.NetworkAnalyzer;
using Equipment.Positioner;
using Actions.DataStore.Services;

var builder = WebApplication.CreateBuilder(args);

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddGrpcClient<Positioner.PositionerClient>(o =>
{
    o.Address = new Uri("http://localhost:5150");
});
builder.Services.AddGrpcClient<NetworkAnalyzer.NetworkAnalyzerClient>(o =>
{
    o.Address = new Uri("http://localhost:5150");
});
builder.Services.AddGrpcClient<PositionerIterator.PositionerIteratorClient>(o =>
{
    o.Address = new Uri("http://localhost:5185");
});
builder.Services.AddGrpcClient<MeasureIterator.MeasureIteratorClient>(o =>
{
    o.Address = new Uri("http://localhost:5185");
});
builder.Services.AddGrpcClient<DataStore.DataStoreClient>(o =>
{
    o.Address = new Uri("http://localhost:5185");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<PositionerIteratorService>();
app.MapGrpcService<MeasureIteratorService>();
app.MapGrpcService<DataStoreService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
