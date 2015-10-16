using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Collections.Generic;

namespace Boom
{
	public class BoomPayload {
		public HttpStatusCode statusCode;
		public string error;
		public string message;
	}

	public class BoomOutput
	{

		public HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
		public Dictionary<string, string> headers = new Dictionary<string, string>();

		private string message;

		public BoomPayload payload {
			get {
				return new BoomPayload() {
					statusCode = this.statusCode,
					error = this.getErrorMessage(),
                    message = this.getErrorMessage() + (this.message != null && this.message.Length > 0 
                            ? ": " + this.message 
                            : "")
				};
			}
			set { }
		}


		public BoomOutput (string _message, HttpStatusCode _statusCode)
		{
			statusCode = _statusCode;
			message = _message;
		}

		public string getErrorMessage()
		{
			return MessageFromStatusCode (this.statusCode);
		}

		public static string MessageFromStatusCode(HttpStatusCode code) {
			return new HttpResponseMessage (code).ReasonPhrase;
		}
	}
}

