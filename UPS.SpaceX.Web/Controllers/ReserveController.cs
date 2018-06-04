using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPS.SpaceX.BLL;

namespace UPS.SpaceX.Web.Controllers
{
    public class ReserveController : Controller
    {
        // GET: Reserve
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetGivers(UPS.SpaceX.DAL.Giver giver)
        {
            try
            {
                var availableDesks = ReserveService.GetGivers(giver.date);

                return PartialView("~/Views/Home/_Reserve.cshtml", availableDesks);
            }
            catch (Exception e)
            {
                return Json(new { Success = false, Data = e.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult InsertRecord(UPS.SpaceX.DAL.Recipient recipient)
        {
            try
            {
                // TODO: Add insert logic here
                // call BLL which then calls DAL to insert donor
                UPS.SpaceX.BLL.ReserveService.InsertRecord(recipient);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return Json(new { Success = false, Data = ex.Message }, JsonRequestBehavior.AllowGet);
                // View();
            }
        }

        public ActionResult UpdateDonorFlag(UPS.SpaceX.DAL.Giver giver)
        {
            try
            {
                // TODO: Add insert logic here
                // call BLL which then calls DAL to insert donor
                UPS.SpaceX.BLL.ReserveService.UpdateDonorFlag(giver);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Json(new { Success = false, Data = ex.Message }, JsonRequestBehavior.AllowGet);
                // View();
            }
        }

        //public ActionResult updateDB(UPS.SpaceX.DAL.Giver giver)
        //{
        //    try
        //    {
        //        UPS.SpaceX.BLL.ReserveService.UpdateDB(giver);

        //        return PartialView("~/Views/Home/_Reserve.cshtml");
        //    }
        //    catch (Exception e)
        //    {
        //        return Json(new { Success = false, Data = e.Message }, JsonRequestBehavior.AllowGet);
        //    }
        //}

        // GET: Reserve/Details/5
        public ActionResult Details()
        {

            return View();
        }

        // GET: Reserve/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reserve/Create
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

        // GET: Reserve/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reserve/Edit/5
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

        // GET: Reserve/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reserve/Delete/5
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
