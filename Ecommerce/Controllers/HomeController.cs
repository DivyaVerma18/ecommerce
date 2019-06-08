using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A shopping website.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Divya Verma.";

            return View();
        }
    }
}