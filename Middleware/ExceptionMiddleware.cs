using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace api.Middleware
{
    public class ExceptionMiddleware //returns a standarzied json error response.
    {
        private readonly RequestDelegate _next;// Represents the next middleware component in the pipeline.
        private readonly ILogger<ExceptionMiddleware> _logger;// Logger used to record exception details.

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)// Constructor injects RequestDelegate and ILogger via dependency injection.
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)// Invoked for every HTTP request.
        {
            try
            {
                await _next(context);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "unhandled exception occurred");

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.ContentType = "application/json";

                var respons = new
                {
                    massage = "unexpected error occurred ",
                    details = ex.Message
                };

                var json = JsonSerializer.Serialize(respons);
                await context.Response.WriteAsync(json);
            }
        }
    }
}