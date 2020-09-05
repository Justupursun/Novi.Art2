using Novi.Art.Models;
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

            ViewBag.Product = new Product
            {
                Name = "lovecouple",
                //                FullPrice = 20.00M,
                CurrentPrice = 16.00M,
                //                PercentOff = 20,
                ImagePath = "~/Content/Images/Products/lovecouple.png",
                StarRating = 4,
                StartDate = DateTime.Now.Date,
                EndDate = DateTime.Now.AddDays(60)
            };
            //lookup the productname in the database
            return View();
        }
    }
}