using Nortwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nortwind.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public ActionResult List(int category = 0)
        {
            ViewBag.CurrentCategory = category;
            return PartialView(categoryService.GetAll());
        }
    }
}