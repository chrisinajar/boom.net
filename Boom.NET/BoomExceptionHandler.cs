using System;
using System.Diagnostics;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace Boom
{
    public class BoomExceptionHandler : ExceptionHandler
	{
		public override void Handle(ExceptionHandlerContext context)
		{
            Trace.WriteLine("The exception filter is running!!");
            if (context.Exception == null)
            {
                return;
            }
            BoomException exception;
            if (context.Exception is BoomException)
            {
				exception = context.Exception as BoomException;
            } else {
                exception = new InternalError(context.Exception);
            }

            context.Result = new ResponseMessageResult(context.Request.CreateResponse(exception.output.statusCode, exception.output.payload));
		}
	}
}

