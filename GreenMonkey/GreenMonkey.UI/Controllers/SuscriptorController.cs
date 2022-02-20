using GreenMonkey.UI.Models;
using GreenMonkey.UI.Services;
using GreenMonkey.UI.ViewModels;
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

        public ActionResult Details(string code)
        {
            if (string.IsNullOrEmpty(code))
                RedirectToAction("NotFound", "Error");

            var suscriptor = _service.RetreaveSuscriptor(code);

            if(suscriptor == null)
                RedirectToAction("NotFound", "Error");

            return View(suscriptor);
        }

        // GET: Suscriptor/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult SuscriptorForm()
        {
            var suscriptorViewModel = new SuscriptorForViewModel() { 
                Heading = "Registrar suscriptor"
            };

            return View(suscriptorViewModel);
        }

        public ActionResult Edit(string code)
        {
            if (string.IsNullOrEmpty(code))
                RedirectToAction("NotFound", "Error");

            var suscriptor = _service.RetreaveSuscriptor(code);

            if (suscriptor == null)
                RedirectToAction("NotFound", "Error");

            var suscriptorViewModel = new SuscriptorForViewModel() {
                Code = suscriptor.Code,
                Name = suscriptor.Name,
                Owner = suscriptor.Owner,
                Description = suscriptor.Description,
                BaseUrl = suscriptor.BaseUrl,
                Heading = "Editar suscriptor"
            };

            return View("SuscriptorForm", suscriptorViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(SuscriptorForViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("SuscriptorForm", viewModel);
                }

                _service.EditSuscriptor(new Suscriptor
                {
                    Code = viewModel.Code,
                    Name = viewModel.Name,
                    Owner = viewModel.Owner,
                    Description = viewModel.Description,
                    BaseUrl = viewModel.BaseUrl
                });

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
