using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2._2.Models;

namespace Lab2._2.Controllers
{
    public class TickTackTowController : Controller
    {
        // GET: TickTackTow
        public ActionResult Index()
        {
            TickTackTow m = new TickTackTow();
            //m.PlayerONumbers.Add(0);
            //m.PlayerXNumbers.Add(0);
            return View(m);
        }
        [HttpPost]
        public ActionResult Index(TickTackTow model)
        {
            if (!model.GameOver)
            {
                model.AddNumber();
                model.CheckIfWon();
                ModelState.Clear();
            }

            return View(model);
        }
    }
}