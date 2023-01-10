using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace BuffetDinner.Api.Filters
{
    public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            //var errorResult = new { error = "An error occurred while processing your request." };
            var problemDetails = new ProblemDetails
            {
                Title = "An error occurred while processing your request.",
                Status = (int)HttpStatusCode.InternalServerError
            };

            context.Result = new ObjectResult(problemDetails)
            {
                StatusCode = problemDetails.Status,
            };

            context.ExceptionHandled = true;
            base.OnException(context);
        }
    }
}
