using Nortwind.Entities;
using Nortwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nortwind.MvcWebUI.Controllers
{
    public class CartController : Controller
    {

        IProductService productService;

        public CartController(IProductService productService)
        {
            this.productService = productService;
        }

       public RedirectToRouteResult AddToCart(Cart cart,int productId)
        {

            Product product = productService.Get(productId);
            /*
             * ModelBinder Ile Gerek Kalmadi Bu Bolume
            var cart = (Cart)Session["cart"];
            if (Session["cart"] == null)
            {
                cart = new Cart();
                Session["cart"] = cart;
            }

            */
            cart.AddToCart(product, 1);

            //return View("Index",cart);
            return RedirectToAction("Index", cart);
        }

        public ViewResult Index(Cart cart)
        {
            return View(cart);
        }

        public RedirectToRouteResult RemoveFromCart(Cart cart,int urun)
        {

            Product product = productService.Get(urun);

            
            cart.RemoveToCart(product);

            return RedirectToAction("Index", cart);


        }
        public ActionResult Checkout()
        {

            return View(new ShippingDetails());

        }
        [HttpPost]
        public ActionResult Checkout(ShippingDetails shippingDetails)
        {
            if (ModelState.IsValid)
            {
                return View("Completed");
            }
            else
            {
                return View(shippingDetails);
            }


        }
        public PartialViewResult CartSummary(Cart cart)
        {

            return PartialView(cart);
        }
    }
}
















