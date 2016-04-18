using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class LifeController : Controller
    {
        // GET: Life
        public ActionResult SuperMario()
        {
            return View();
        }

        public ActionResult Health()
        {
            return View();
        }

        public ActionResult Live()
        {
            return View();
        }
    }
}