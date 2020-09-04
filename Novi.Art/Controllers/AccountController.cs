using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Novi.Art.Controllers
{
    // 1 authentication filters are responsible for verifying your identity via a cookie once you've already logged in. 
    // 2 Authorize filters are resposible to secure access to only logged in users accessing the account page. These are typically concerned with whether or not a specific user has access to a specific route or action
    // 3 Action filters can choose whether to execute during the OnAction executing handler, which is run right before the action method, or during the on action executed handler which is after the action method, or, of course, they can run in both. 
    // 4 Results filter. These run after the action method finishes and after the returned view result is already rendered. These can be helpful if, for example, you'd like to parce the final HTML and make some changes to it before sending it off to the browser.
    // 5 exception filter runs last and only if an unhandled exception has bubbled up through the action method in your controller. This is meant to be sort of a fail-safe to handle any exceptions that make it this far without having been handled in some other way. 


    [Authorize] // Check for a valite user to allow access to all of the actions in this controller
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
    }
}