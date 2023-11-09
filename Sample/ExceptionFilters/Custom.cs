using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace Sample.ExceptionFilters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is NotImplementedException)
            {
                context.Result = new Microsoft.AspNetCore.Mvc.ObjectResult("Resource not implemented")
                {
                    StatusCode = (int)HttpStatusCode.NotFound
                };
                context.ExceptionHandled = true;
            }
        }
    }
}
