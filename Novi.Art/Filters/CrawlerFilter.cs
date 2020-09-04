using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Novi.Art.Filters
{
    public class CrawlerFilter : ActionFilterAttribute // To make this an action method we just need to inherit from the action filter attribute.
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Request.Browser.Crawler) // This'll return true if the client is a known web crawler that is indexing the web. If it is, return a 404 response. 
            {
                filterContext.Result = new HttpNotFoundResult();
            }
        }
    }
}