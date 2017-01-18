using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApiWebApplication.Controllers
{
    public class AuctionHouseController : Controller
    {
        // GET: AuctionHouse
        public ActionResult Index()
        {
            return View();
        }

        // GET: AuctionHouse/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AuctionHouse/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuctionHouse/Create
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

        // GET: AuctionHouse/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AuctionHouse/Edit/5
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

        // GET: AuctionHouse/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AuctionHouse/Delete/5
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
