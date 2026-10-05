using EIMS.Application.Exceptions;
using EIMS.Domain.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace EIMS.API.ExceptionHandling;

internal sealed class ApiExceptionHandler(IProblemDetailsService problemDetailsService) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        if(exception is DomainException domainException) 
        {
            httpContext.Response.StatusCode = 400;

            var problemDetailsContext = new ProblemDetailsContext
            {
                HttpContext = httpContext,
                ProblemDetails = new ProblemDetails
                {
                    Status = 400,
                    Title = "Validation Failed",
                    Detail = domainException.Message
                }
            };

            await problemDetailsService.TryWriteAsync(problemDetailsContext);

            return true;
        }

        if (exception is ProductAlreadyExistsException productAlreadyExistsException)
        {
            httpContext.Response.StatusCode = 400;

            var problemDetailsContext = new ProblemDetailsContext
            {
                HttpContext = httpContext,
                ProblemDetails = new ProblemDetails
                {
                    Status = 400,
                    Title = "Validation Failed",
                    Detail = productAlreadyExistsException.Message
                }
            };

            await problemDetailsService.TryWriteAsync(problemDetailsContext);

            return true;
        }

        return false;
    }
}
