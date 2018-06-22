using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerConversion.Controllers
{
    public class FootInchesController : Controller
    {
        // GET: FootInches
        public ActionResult FootInches()
        {
            return View(viewName: "FootInches", model: 0);
        }
        public ActionResult Convert(double feet)
        {
            double inches = feet * 12;
            return View(viewName: "FootInches", model: inches);
        }
    }
}