using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Novi.Art.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            // return View("~/Views/Product/Index.cshtml");
            return View("Index");
        }

        [Route("product/{productName}")] //(Attribute routing)
        public ActionResult Detail(string productName)
        {
            //lookup the productname in the database
            return View();
        }
    }
}