using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Novi.Art.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // create a valid login-cookie when login the loginform is summited
        [HttpPost] // this will tell asp.NET MVC 5 to route any post requests to this index route to this specific method
        public ActionResult Index(string username, string password)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                FormsAuthentication.SetAuthCookie(username, false);                     // Using System.Web.Security
                return Redirect(FormsAuthentication.GetRedirectUrl(username, false));
            }

            ViewBag.Failed = true;
            return View();
        }
    }
}