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
            ViewBag.Message = "Aby rozpocząć kliknij na jeden z poniższych linków:";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "System Obslugi Studenta";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kontakt";

            return View();
        }
    }
}
