using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Module04Demos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Params()
        {
            return Content(string.Format("color: {0}, age: {1}, range: {2}",
                Request.Form["color"], 
                Request.Form["age"], Request.Form["agerange"]));
        }
    }
}