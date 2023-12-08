using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BuberDinner.Application.Common.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuberDinner.Api.Filter
{
    public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var problemDetails = new ProblemDetails
            {
                Title = exception.Message,
                Status = exception switch
                {
                    DuplicateEmailException => 400,
                    UnauthorizedAccessException => 401,
                    KeyNotFoundException => 404,
                    _ => 500
                }
            };

            context.Result = new ObjectResult(problemDetails);
            context.ExceptionHandled = true;
        }
    }
}