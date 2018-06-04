using System;
using System.Web.Mvc;
using UPS.SpaceX.BLL;

namespace UPS.SpaceX.Web.Controllers
{
    public class SpaceXController : Controller
    {
        // GET: SpaceX
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAvailableDesks()
        {
            try
            {
                var availableDesks = SpaceXCommon.GetAvailableDesks();

                return PartialView("~/Views/Home/_AvailableDesks.cshtml", availableDesks);
            }
            catch (Exception e)
            {
                return Json(new { Success = false, Data = e.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}