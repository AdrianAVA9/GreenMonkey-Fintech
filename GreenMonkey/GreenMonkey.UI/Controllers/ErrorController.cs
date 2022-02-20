using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreenMonkey.UI.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult NotFound(string message)
        {
            return View(message);
        }
    }
}