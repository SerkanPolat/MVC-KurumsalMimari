using Nortwind.Dal.Concrete.EntityFramework;
using Nortwind.Dll.Concrete;
using Nortwind.Entities;
using Nortwind.Interfaces;
using Nortwind.MvcWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nortwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        public int PageSize = 5;
        public ViewResult Index(int page=1,int category = 0)
        {

            List<Product> products = productService.GetAll()
                .Where(p => p.CategoryID == category||category==0).ToList();




            return View(new ProductViewModel
            {
                Products = products.Skip((page - 1) * PageSize).Take(5).ToList(),
                PagingInfo = new PagingInfo
                {
                    ItemsPerPage = PageSize,
                    TotalItems = products.Count,
                    CurrentPage = page,
                    CurrentCategory = category

                }

            });
        }
    }
}