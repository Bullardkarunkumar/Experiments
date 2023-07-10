using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32;
using NationalInstruments.Visa;
using VisaGrpcService;

namespace GrpcVisa
{
	public static class VisaComm
	{
		private static Dictionary<String, MessageBasedSession> sessions;

		public static void init()
		{
			sessions = new Dictionary<String, MessageBasedSession>();
		}

		public static VisaResponse Open(string address)
		{
			VisaResponse vr = new VisaResponse();
			MessageBasedSession mbSession;
			using (var rmSession = new ResourceManager())
			{
				try
				{
					mbSession = rmSession.Open(address) as MessageBasedSession;
					if (mbSession == null)
					{
						vr.Succeded = false;
						vr.Message  = "Could not open session";
						return vr;
					}
					mbSession.TerminationCharacterEnabled = true;
					//mbSession.TimeoutMilliseconds = timeOut;

				}
				catch (Exception e)
				{
//					Debugger.Break();
					vr.Message = e.Message;
					vr.Succeded = false;
					return vr;
				}
			}

			Guid guid = Guid.NewGuid();
			string sessionToken = guid.ToString();
			sessions?.Add(sessionToken, mbSession);
			vr.Succeded = true ;
			vr.Message = sessionToken;
			return vr;
		}

		public static VisaResponse Close(string sessionToken)
		{
			MessageBasedSession session;
			VisaResponse vr = new VisaResponse();
			if (sessions.TryGetValue(sessionToken, out session))
			{
				if (session != null && !session.IsDisposed)
				{
					session.Clear();
					session.Dispose();
					vr.Message = "Could not retrieve session / connection information.";
					vr.Succeded = false;
					return vr;
				}

				sessions.Remove(sessionToken);
			}
			else
			{
				vr.Message = "Could not retrieve session / connection information.";
				vr.Succeded = false;
				return vr;
			}
			return vr;
		}

		public static VisaResponse WriteToSession(string command, string sessionToken)
		{
			VisaResponse vr = new VisaResponse();
			MessageBasedSession session;
			if (sessions.TryGetValue(sessionToken, out session))
			{
				try
				{
					var message = command.Trim() + '\n';
					session.RawIO.Write(message);
				}
				catch (Exception ex)
				{
					vr.Succeded = false;
					vr.Message = ex.Message;
					return vr;
				}
			}
			else
			{
				vr.Message = "Could not retrieve session / connection information.";
				vr.Succeded = false;
				return vr;
			}
			vr.Message = string.Empty;
			vr.Succeded = true;
			return vr;
		}

		public static VisaResponse ReadFromSession(string sessionToken)
		{
			MessageBasedSession session;
			VisaResponse response = new VisaResponse();
			if (sessions.TryGetValue(sessionToken, out session))
			{
				response.Message = session.RawIO.ReadString().Trim();
				response.Succeded = (response.Message != null);
			}
			else
			{
				response.Message = "Could not retrieve session / connection information.";
				response.Succeded = false;
				return response;
			}
			return response;
		}

		public static VisaResponse QuerySession(string command, string sessionToken)
		{
			MessageBasedSession session;
			VisaResponse response = new VisaResponse();
			if (sessions.TryGetValue(sessionToken, out session))
			{
				command = command.Trim() + '\n'; // Remove leading/trailing whitespace add terminator
				session.RawIO.Write(command);
				response.Message = session.RawIO.ReadString().Trim();
				response.Succeded = (response.Message != null);
			}
			else
			{
				response.Message = "Could not retrieve session / connection information.";
				response.Succeded = false;
				return response;
			}
			return response;
		}

	}
}
