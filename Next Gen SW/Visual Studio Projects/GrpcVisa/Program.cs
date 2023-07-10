using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VisaGrpcService.Services;
//using PosGrpcService.Services;


namespace GrpcVisa
{
	public struct Vresponse
	{
		public string status;
		public string message;
	}

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
		static async Task Main(string[] args)
		{
			VisaComm.init();
			var hostBuilder = new HostBuilder()
				// Add configuration, logging, ...
				.ConfigureServices((hostContext, services) =>
				{
					// Better to use Dependency Injection for GreeterImpl
					Server server = new Server
					{
						Services = { VisaGrpcService.VisaConnect.BindService(  new VisaService()) },
						Ports = { new ServerPort("localhost", 15003, ServerCredentials.Insecure) }
					};
					services.AddSingleton<Server>(server);
					services.AddSingleton<IHostedService, GrpcHostedService>();
				});

			await hostBuilder.RunConsoleAsync();
		}
	}
}
