using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerConversion.Controllers
{
    public class FeetController : Controller
    {
        // GET: Feet
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FeeetToMiles()
        {
            return View(viewName: "FeeetToMiles", model: 0);
        }

        [HttpPost]
        public ActionResult Converter(int Feet)
        {
            int Milesconvert = (Feet) / 5280;
            return View(viewName: "FeeetToMiles", model: (Milesconvert));
        }
    }
}