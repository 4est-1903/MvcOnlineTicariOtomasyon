using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Threading.Tasks;
using MvcOnlineTicariOtomasyon.Models;


namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class AccountController : Controller
    {
        public class AccountController1 : Controller
        {
            private ApplicationUserManager UserManager
            {
                get { return HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>(); }
            }

            private IAuthenticationManager AuthenticationManager
            {
                get { return HttpContext.GetOwinContext().Authentication; }
            }

            public ActionResult Login()
        {
            return View();
        }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<ActionResult> Login(string username, string password)
            {
                var user = await UserManager.FindAsync(username, password);
                if (user != null)
                {
                    var identity = await UserManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                    AuthenticationManager.SignIn(new AuthenticationProperties { IsPersistent = false }, identity);
                    return RedirectToAction("Index", "Home");
                }
                ViewBag.Error = "Geçersiz kullanıcı adı veya şifre";
                return View();
            }

            public ActionResult Logout()
            {
                AuthenticationManager.SignOut();
                return RedirectToAction("Login");
            }

        }
}
}