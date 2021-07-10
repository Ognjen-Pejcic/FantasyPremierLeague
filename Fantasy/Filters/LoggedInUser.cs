using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fantasy.Filters
{
    public class LoggedInUser:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Filters.OfType<NotLoggedIn>().Any())
            {
                return;
            }

            if(context.HttpContext.Session.GetInt32("userid") == null)
            {
                context.HttpContext.Response.Redirect("/user/inedx");
                return;
            }
        }
    }
}
