using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class StringActivityController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "All starts here.");
        }
        [HttpPost]
        public ActionResult SayHello(string inputString)
        {
            int length = inputString.Length;
            return View(viewName: "Index", model: "The length of your name is: "+length);
        }
    }
}