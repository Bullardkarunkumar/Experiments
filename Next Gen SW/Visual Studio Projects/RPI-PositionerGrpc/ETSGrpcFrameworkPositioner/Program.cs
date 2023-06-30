using Grpc.Core;
using PosGrpcService.Services;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ETSGrpcFrameworkPositioner
{
    public class GrpcHostedService : IHostedService
    {
        private Server _server;

        public GrpcHostedService(Server server)
        {
            _server = server;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _server.Start();
            return Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken) => await _server.ShutdownAsync();
    }

    internal class Program
    {
        public static async Task Main(string[] args)
        {

            var hostBuilder = new HostBuilder()
                      // Add configuration, logging, ...
                      .ConfigureServices((hostContext, services) =>
                      {
                          // Better to use Dependency Injection for GreeterImpl
                          Server server = new Server
                          {
                              Services = { PosGrpcService.Positioner.BindService(new PositionerService()) },
                              Ports = { new ServerPort("localhost", 30051, ServerCredentials.Insecure) }
                          };
                          services.AddSingleton<Server>(server);
                          services.AddSingleton<IHostedService, GrpcHostedService>();
                      });

            await hostBuilder.RunConsoleAsync();

        }
    }
}
