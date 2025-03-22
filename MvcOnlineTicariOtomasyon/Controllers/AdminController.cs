using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineTicariOtomasyon.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin Panel Sayafası
        public ActionResult Index()
        {
            return View();
        }

        // Ürünler Sayfası
        public ActionResult Products()
        {
            return View();
        }

        // Siparişler Sayfası
        public ActionResult Orders()
        {
            return View();
        }

        // Kullanıcılar Sayfası
        public ActionResult Users()
        {
            return View();
        }

        // Giriş (Login) Sayfası
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                Session["Admin"] = username;
                return RedirectToAction("Index");
            }
            ViewBag.Error = "Geçersiz kullanıcı adı veya şifre";
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
