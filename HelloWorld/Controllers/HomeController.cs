using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Click one from the below links to jump to desired functionallity:";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "System Obslugi Studenta";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Autorzy aplikacji";

            return View();
        }
    }
}
