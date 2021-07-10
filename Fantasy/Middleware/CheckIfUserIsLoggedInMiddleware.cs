using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantasy.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CheckIfUserIsLoggedInMiddleware
    {
        private readonly RequestDelegate _next;

        public CheckIfUserIsLoggedInMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            int? id = httpContext.Session.GetInt32("userid");
            if (id == null && (httpContext.Request.Path != "/user/index" && httpContext.Request.Path != "/user/index#toregister"))
            {
                httpContext.Response.Redirect("/user/index");
            }
            Console.WriteLine(id);
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class CheckIfUserIsLoggedInMiddlewareExtensions
    {
        public static IApplicationBuilder UseCheckIfUserIsLoggedInMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CheckIfUserIsLoggedInMiddleware>();
        }
    }
}
