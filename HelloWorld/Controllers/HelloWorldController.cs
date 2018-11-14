using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        [HttpGet]
        public ViewResult HelloWorld()
        {
            return View();
        }
    }
}
