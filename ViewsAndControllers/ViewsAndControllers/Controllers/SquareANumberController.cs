using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class SquareANumberController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index",model: 0.0);
        }
        public ActionResult MagicNumber()
        {
            return View(viewName: "MagicNumber", model: 0);
        }
        [HttpPost]
        public ActionResult SaySquare(double inputNumber)
        {
            return View(viewName: "Index", model: Math.Sqrt(inputNumber));
        }
        [HttpPost]
        public ActionResult MakeMagic(int firstNumber, int secondNumber)
        {
            return View(viewName: "MagicNumber", model: new Random().Next(firstNumber,secondNumber));
        }
    }
}