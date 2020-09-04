using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Novi.Art.Controllers
{
    public class HomeController : Controller // Inherits from the Controllor-class
    {
        // System.Web.Mvc View --> ViewResult --> ViewResultBase --> ActionResult
        // there's a polymorphic relationship between ActionResults and ViewResults. 
        // action methods can return anything that inherits from a (abstract) class called ActionResult.
        // because it's abstract, we can't actually instantiate one of these in an action method. 
        // Instead, this class has to be inherited by a derived class.

        public ActionResult Index()
        {
            return View(); // the return type that is being used for our index method is the ActionResult-class itself.
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

//Response helpers:
// ViewResult
// EmptyResult          // 200 OK status Content-Length: 0
// RedirectResult       // Tells the browser to send the user o a different url
                        // Redirect*, RedirectToAction, RedirectToRoute
// JsonResult           // Returns JSON-data. You may use a web-api2.2 application instead of JSON-5
// JavaScriptResult
// ContentResult
// FileContentResult // For downloading content
// FilePathResult
// FileStreamResult