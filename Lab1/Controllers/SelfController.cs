﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class SelfController : Controller
    {
        // GET: Self
        public ActionResult B2B(string id)
        {
            ViewBag.id = id;
            return View();
        }

        public ActionResult B2C(string id)
        {
            return View();
        }

        public ActionResult C2C()
        {
            return View();
        }

        public ActionResult Completion()
        {
            return View();
        }
    }
}