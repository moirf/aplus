using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APlus.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "APlusPoint - Platform to Excel ...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "APlusPoint - Contact Us";

            return View();
        }
    }
}