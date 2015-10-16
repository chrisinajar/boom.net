using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace Boom
{
	public class BoomException : Exception
	{
		// not static because we want (e.isBoom) to work
		// also basically entirely pointless because statically typed, but whatever
		public readonly bool isBoom = true;
		public bool isServer {
			get {
				return this.output.statusCode >= System.Net.HttpStatusCode.InternalServerError;
			}
			set { }
		}
		public BoomOutput output;

        public BoomException(string _message, HttpStatusCode _statusCode = HttpStatusCode.InternalServerError)
            : base(_message)
        {
            output = new BoomOutput(_message, _statusCode);
        }
        public BoomException(Exception innerException, string _message = "", HttpStatusCode _statusCode = HttpStatusCode.InternalServerError)
            : base(_message, innerException)
        {
            output = new BoomOutput(_message, _statusCode);
        }
	}
}
