using GreenMonkey.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GreenMonkey.UI.Controllers
{
    public class SuscriptorController : Controller
    {
        private SuscriptorService _service { get; set; }

        public SuscriptorController()
        {
            _service = new SuscriptorService();
        }
        public ActionResult Index()
        {
            var sucriptors = _service.RetreaveSuscriptors();
            return View(sucriptors);
        }

        // GET: Suscriptor/Details/5
        public ActionResult Details(string code)
        {
            return View();
        }

        // GET: Suscriptor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Suscriptor/Create
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

        // GET: Suscriptor/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Suscriptor/Edit/5
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

        // GET: Suscriptor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Suscriptor/Delete/5
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
