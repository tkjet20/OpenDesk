using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UPS.SpaceX.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Donate()
        {
            ViewBag.Message = "UPS OpenDesk";

            return View();
        }

        public ActionResult Reserve()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult FloorMap()
        {
            ViewBag.Message = "Your mapppp page.";

            return View();
        }

        public ActionResult LookUp()
        {
            ViewBag.Message = "Your mapppp page.";

            return View();
        }


    }
}