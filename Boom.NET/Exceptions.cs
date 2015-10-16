using System;
using System.Net;

namespace Boom
{
	public class BadRequest : BoomException
	{
		public BadRequest(string message = null)
			: base(message, HttpStatusCode.BadRequest)
		{
		}
	}
	public class Unauthorized : BoomException
	{
		public Unauthorized(string message = null)
			: base(message, HttpStatusCode.Unauthorized)
		{
		}
	}
	public class Forbidden : BoomException
	{
		public Forbidden(string message = null)
			: base(message, HttpStatusCode.Forbidden)
		{
		}
	}
	public class NotFound : BoomException
	{
		public NotFound(string message = null)
			: base(message, HttpStatusCode.NotFound)
		{
		}
	}
	public class MethodNotAllowed : BoomException
	{
		public MethodNotAllowed(string message = null)
			: base(message, HttpStatusCode.MethodNotAllowed)
		{
		}
	}
	public class NotAcceptable : BoomException
	{
		public NotAcceptable(string message = null)
			: base(message, HttpStatusCode.NotAcceptable)
		{
		}
	}
	public class ProxyAuthRequired : BoomException
	{
		public ProxyAuthRequired(string message = null)
			: base(message, HttpStatusCode.ProxyAuthenticationRequired)
		{
		}
	}
	public class ClientTimeout : BoomException
	{
		public ClientTimeout(string message = null)
			: base(message, HttpStatusCode.RequestTimeout)
		{
		}
	}
	public class Conflict : BoomException
	{
		public Conflict(string message = null)
			: base(message, HttpStatusCode.Conflict)
		{
		}
	}
	public class ResourceGone : BoomException
	{
		public ResourceGone(string message = null)
			: base(message, HttpStatusCode.Gone)
		{
		}
	}
	public class LengthRequired : BoomException
	{
		public LengthRequired(string message = null)
			: base(message, HttpStatusCode.LengthRequired)
		{
		}
	}
	public class PreconditionFailed : BoomException
	{
		public PreconditionFailed(string message = null)
			: base(message, HttpStatusCode.PreconditionFailed)
		{
		}
	}
	public class EntityTooLarge : BoomException
	{
		public EntityTooLarge(string message = null)
			: base(message, HttpStatusCode.RequestEntityTooLarge)
		{
		}
	}
	public class UriTooLong : BoomException
	{
		public UriTooLong(string message = null)
			: base(message, HttpStatusCode.RequestUriTooLong)
		{
		}
	}
	public class UnsupportedMediaType : BoomException
	{
		public UnsupportedMediaType(string message = null)
			: base(message, HttpStatusCode.UnsupportedMediaType)
		{
		}
	}
	public class RangeNotSatisfiable : BoomException
	{
		public RangeNotSatisfiable(string message = null)
			: base(message, HttpStatusCode.RequestedRangeNotSatisfiable)
		{
		}
	}
	public class ExpectationFailed : BoomException
	{
		public ExpectationFailed(string message = null)
			: base(message, HttpStatusCode.ExpectationFailed)
		{
		}
	}

	public class InternalError : BoomException
    {
        public InternalError(HttpStatusCode statusCode, string message)
            : base(message, statusCode)
        {
        }
        public InternalError(Exception exception, HttpStatusCode statusCode = HttpStatusCode.InternalServerError, string message = null)
            : base(exception, message, statusCode)
        {
        }
	}
	public class NotImplemented : BoomException
	{
		public NotImplemented(string message = null)
			: base(message, HttpStatusCode.NotImplemented)
		{
		}
	}
	public class BadGateway : BoomException
	{
		public BadGateway(string message = null)
			: base(message, HttpStatusCode.BadGateway)
		{
		}
	}
	public class ServerTimeout : BoomException
	{
		public ServerTimeout(string message = null)
			: base(message, HttpStatusCode.ServiceUnavailable)
		{
		}
	}
	public class GatewayTimeout : BoomException
	{
		public GatewayTimeout(string message = null)
			: base(message, HttpStatusCode.GatewayTimeout)
		{
		}
	}
	public class BadImplementation : BoomException
	{
		public BadImplementation(string message = null)
			: base(message, HttpStatusCode.InternalServerError)
		{
		}
	}
}
