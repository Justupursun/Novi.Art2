using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Novi.Art.Filters
{
    public class CustomExceptionHandler : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var bytes = System.IO.File.ReadAllBytes(filterContext.HttpContext.Server.MapPath("/error/500.html"));
            filterContext.Result = new FileContentResult(bytes, "text/html");
            filterContext.ExceptionHandled = true;
        }
    }
}