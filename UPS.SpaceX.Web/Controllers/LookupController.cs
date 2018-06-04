using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPS.SpaceX.BLL;

namespace UPS.SpaceX.Web.Controllers
{
    public class LookupController : Controller
    {
        // GET: Lookup
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetRecipientTable(UPS.SpaceX.DAL.Recipient recipient)
        {
            try
            {
                var recipientTable = LookupService.GetRecipientTable(recipient.email);

                return PartialView("~/Views/Home/_LookupRecipient.cshtml", recipientTable);
            }
            catch (Exception e)
            {
                return Json(new { Success = false, Data = e.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetDonorTable(UPS.SpaceX.DAL.Giver giver)
        {
            try
            {
                var donorTable = LookupService.GetDonorTable(giver.email);

                return PartialView("~/Views/Home/_LookupDonor.cshtml", donorTable);
            }
            catch (Exception e)
            {
                return Json(new { Success = false, Data = e.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult GetKP(UPS.SpaceX.DAL.Giver giver)
        {
            try
            {
                var KP = LookupService.GetKP(giver.email);

                return PartialView("~/Views/Home/_LookupKP.cshtml", KP);
            }
            catch (Exception e)
            {
                return Json(new { Success = false, Data = e.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Lookup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Lookup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lookup/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Lookup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Lookup/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Lookup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Lookup/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
