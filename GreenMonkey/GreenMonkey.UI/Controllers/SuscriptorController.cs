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
                return RedirectToAction("NotFound", "Error");

            var suscriptor = _service.RetreaveSuscriptor(code);

            if (suscriptor == null)
                return RedirectToAction("NotFound", "Error");

            return View(suscriptor);
        }

        public ActionResult SuscriptorForm()
        {
            var suscriptorViewModel = new SuscriptorForViewModel()
            {
                Heading = "Registrar suscriptor",
                FormAction = Models.Enums.FormAction.Create
            };

            return View(suscriptorViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuscriptorForViewModel viewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    viewModel.Heading = "Registrar suscriptor";
                    viewModel.FormAction = Models.Enums.FormAction.Create;
                    return View("SuscriptorForm", viewModel);
                }

                _service.CreateSuscriptor(new Suscriptor
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

        public ActionResult Edit(string code)
        {
            if (string.IsNullOrEmpty(code))
                return RedirectToAction("NotFound", "Error");

            var suscriptor = _service.RetreaveSuscriptor(code);

            if (suscriptor == null)
                return RedirectToAction("NotFound", "Error");

            var suscriptorViewModel = new SuscriptorForViewModel()
            {
                Code = suscriptor.Code,
                Name = suscriptor.Name,
                Owner = suscriptor.Owner,
                Description = suscriptor.Description,
                BaseUrl = suscriptor.BaseUrl,
                Heading = "Editar suscriptor",
                FormAction = Models.Enums.FormAction.Update
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
                    viewModel.Heading = "Editar suscriptor";
                    viewModel.FormAction = Models.Enums.FormAction.Update;
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

        public ActionResult Delete(string code)
        {
            if (string.IsNullOrEmpty(code))
                return RedirectToAction("NotFound", "Error");

            var suscriptor = _service.RetreaveSuscriptor(code);

            if (suscriptor == null)
                return RedirectToAction("NotFound", "Error");

            return View(suscriptor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(string code)
        {
            try
            {
                if (string.IsNullOrEmpty(code))
                    return RedirectToAction("NotFound", "Error");

                _service.DeleteSuscriptor(code);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
