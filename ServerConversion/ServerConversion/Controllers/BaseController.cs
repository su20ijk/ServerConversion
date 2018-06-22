using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerConversion.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public ActionResult Base()
        {
            return View(viewName: "Base", model: "");
        }
        [HttpPost]
        public ActionResult TurnBinary(int startNumber)
        {
            return View(viewName: "Base", model: Convert.ToString(startNumber, 2));
        }
    }
}