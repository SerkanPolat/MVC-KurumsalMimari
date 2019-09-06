using Nortwind.Entities;
using Nortwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Nortwind.MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private IAuthenticationService authenticationService;

        public AccountController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View(new User());
        }
        [HttpPost]
        public ActionResult Login(User user,string returnUrl)
        {

            User validatedUser = authenticationService.Authenticate(user);

            if (validatedUser == null)
            {

                ModelState.AddModelError("Hata", "Kullanici Adi veya Sifre Yanlis");
            }

            if (ModelState.IsValid)
            {
                if (validatedUser != null)
                {
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    return Redirect(returnUrl);
                }
            }
            return View();
        }
    }
}