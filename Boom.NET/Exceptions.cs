using System;

namespace Boom
{
	public class BadRequest : BoomException
	{
		public BadRequest(string message = null)
			: base(message, 400)
		{
		}
	}
	public class Unauthorized : BoomException
	{
		public Unauthorized(string message = null)
			: base(message, 401)
		{
		}
	}
	public class Forbidden : BoomException
	{
		public Forbidden(string message = null)
			: base(message, 403)
		{
		}
	}
	public class NotFound : BoomException
	{
		public NotFound(string message = null)
			: base(message, 404)
		{
		}
	}
	public class MethodNotAllowed : BoomException
	{
		public MethodNotAllowed(string message = null)
			: base(message, 405)
		{
		}
	}
	public class NotAcceptable : BoomException
	{
		public NotAcceptable(string message = null)
			: base(message, 406)
		{
		}
	}
	public class ProxyAuthRequired : BoomException
	{
		public ProxyAuthRequired(string message = null)
			: base(message, 407)
		{
		}
	}
	public class ClientTimeout : BoomException
	{
		public ClientTimeout(string message = null)
			: base(message, 408)
		{
		}
	}
	public class Conflict : BoomException
	{
		public Conflict(string message = null)
			: base(message, 409)
		{
		}
	}
	public class ResourceGone : BoomException
	{
		public ResourceGone(string message = null)
			: base(message, 410)
		{
		}
	}
	public class LengthRequired : BoomException
	{
		public LengthRequired(string message = null)
			: base(message, 411)
		{
		}
	}
	public class PreconditionFailed : BoomException
	{
		public PreconditionFailed(string message = null)
			: base(message, 412)
		{
		}
	}
	public class EntityTooLarge : BoomException
	{
		public EntityTooLarge(string message = null)
			: base(message, 413)
		{
		}
	}
	public class UriTooLong : BoomException
	{
		public UriTooLong(string message = null)
			: base(message, 414)
		{
		}
	}
	public class UnsupportedMediaType : BoomException
	{
		public UnsupportedMediaType(string message = null)
			: base(message, 415)
		{
		}
	}
	public class RangeNotSatisfiable : BoomException
	{
		public RangeNotSatisfiable(string message = null)
			: base(message, 416)
		{
		}
	}
	public class ExpectationFailed : BoomException
	{
		public ExpectationFailed(string message = null)
			: base(message, 417)
		{
		}
	}
	public class BadData : BoomException
	{
		public BadData(string message = null)
			: base(message, 422)
		{
		}
	}
	public class TooManyRequests : BoomException
	{
		public TooManyRequests(string message = null)
			: base(message, 429)
		{
		}
	}

	public class InternalError : BoomException
	{
		public InternalError(int statusCode, string message)
			: base(message, statusCode)
		{
		}
	}
	public class NotImplemented : BoomException
	{
		public NotImplemented(string message = null)
			: base(message, 501)
		{
		}
	}
	public class BadGateway : BoomException
	{
		public BadGateway(string message = null)
			: base(message, 502)
		{
		}
	}
	public class ServerTimeout : BoomException
	{
		public ServerTimeout(string message = null)
			: base(message, 503)
		{
		}
	}
	public class GatewayTimeout : BoomException
	{
		public GatewayTimeout(string message = null)
			: base(message, 504)
		{
		}
	}
	public class BadImplementation : BoomException
	{
		public BadImplementation(string message = null)
			: base(message, 500)
		{
		}
	}
}
