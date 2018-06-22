using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerConversion.Controllers
{
    public class TemperatureController : Controller
    {
        public ActionResult CtoF()
        {
            return View(viewName: "CtoF", model: 0.0);
        }

        [HttpPost]
        public ActionResult CtoF(double inputC)
        {
            return View(viewName: "CtoF", model: inputC * (9 / 5) + 32);
        }
    }
}