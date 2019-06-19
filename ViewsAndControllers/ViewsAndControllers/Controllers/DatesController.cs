using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class DatesController : Controller
    {
        public ActionResult DateView()
        {
            return View(viewName: "DateView",model: DateTime.Today);
        }
        public ActionResult AgeView()
        {
            return View(viewName: "AgeView", model: 0);
        }
        [HttpPost]
        public ActionResult ReceiveDate(DateTime inputDate)
        {
            return View(viewName: "DateView", model: inputDate);
        }
        [HttpPost]
        public ActionResult CalculateAge(DateTime ageInput)
        {
            int age = ageInput.Year;
            return View(viewName: "AgeView", model: age);
        }
    }
}