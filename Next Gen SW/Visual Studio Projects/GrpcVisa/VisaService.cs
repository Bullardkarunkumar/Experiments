using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using GrpcVisa;

namespace VisaGrpcService.Services
{
	public class VisaService : VisaConnect.VisaConnectBase
	{
		private readonly ILogger<VisaService> _logger;

		public VisaService(ILogger<VisaService> logger)
		{
			_logger = logger;
		}

		public VisaService()
		{
			
		}

		//private VisaResponse makeVisaResponse(string status, string message)
		//{
		//	VisaResponse vr = new VisaResponse();
		//	vr.Status = status;
		//	vr.Buffer = message;
		//	return vr;
		//}

		public override Task<VisaResponse> Open(StringValue request, ServerCallContext context)
		{
			var response = Task.Run(() =>  VisaComm.Open(request.Value));
			
			return response;
		}

		public override Task<VisaResponse> Close(StringValue request, ServerCallContext context)
		{
			var response = Task.Run(() => VisaComm.Close(request.Value));

			return response;
		}

		public override Task<VisaResponse> Write(WriteToSession request, ServerCallContext context)
		{
			var response = Task.Run(() => VisaComm.WriteToSession(request.Command, request.SessionToken));

			return response;
		}

		public override Task<VisaResponse> Read(ReadFromSession request, ServerCallContext context)
		{
			var response = Task.Run(() => VisaComm.ReadFromSession( request.SessionToken));

			return response;
		}

		public override Task<VisaResponse> Query(QuerySession request, ServerCallContext context)
		{
			var response = Task.Run(() => VisaComm.QuerySession(request.Command, request.SessionToken));

			return response;
		}

		public override Task<VisaResponse> QuerySessionWithLockout(QuerySession request, ServerCallContext context)
		{
			return base.QuerySessionWithLockout(request, context);
		}
	}
}
