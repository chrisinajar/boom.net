using System;
using System.Net.Http;
using System.Web.Http.Filters;

namespace Boom
{
	public class BoomExceptionFilter : ExceptionFilterAttribute
	{
		public override void OnException(HttpActionExecutedContext context)
		{
			if (context.Exception != null && context.Exception is BoomException)
			{
				BoomException exception = context.Exception as BoomException;

				context.Response = context.Request.CreateResponse (exception.output.statusCode, exception.output.payload);
			}
		}
	}
}

