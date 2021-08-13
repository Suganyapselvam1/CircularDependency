using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CircularDependency.Controllers
{
    public class HomeController : Controller
    {
        private Dependencies _restaurant;
        public HomeController(Dependencies restaurant)
        {
            _restaurant = restaurant;
        }
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
    }
}