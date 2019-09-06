using Nortwind.Entities;
using Nortwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nortwind.MvcWebUI.Controllers
{
    public class AdminController : Controller
    {
        IProductService productService;

        public AdminController(IProductService productService)
        {
            this.productService = productService;
        }

        public ActionResult Index()
        {
            return View(productService.GetAll());
        }
        [Authorize]
        public ActionResult CreateNew()
        {
            return View(new Product());
        }
        [HttpPost]
        [Authorize]
        public ActionResult CreateNew(Product product)
        {
            if (ModelState.IsValid)
            {
                productService.Add(product);
                return RedirectToAction("Index");

            }
            else
            {
                return View(product);
            }
        }
        public ActionResult Edit(int productId)
        {
            Product product = productService.Get(productId);
            return View(product);
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                productService.Update(product);
                return RedirectToAction("Index");

            }
            else
            {
                return View(product);
            }
        }
        public ActionResult Delete(int productId)
        {
            productService.Delete(productId);
            return RedirectToAction("Index");
        }
    }
}