
using System.Runtime.CompilerServices;

namespace NetCore_Practice_2025.Middleware
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("middleware");
            await next(context);
        }
    }

    public static class CustomMiddlewareExtension
    {

        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder app) { 
        
            return app.UseMiddleware<CustomMiddleware>();
        }
    }
}
