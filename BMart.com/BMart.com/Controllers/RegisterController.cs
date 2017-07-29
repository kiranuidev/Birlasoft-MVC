using BMart.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BMart.com.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            ViewBag.PageTitle = "Registration";
            return View();
        }

        public ActionResult Index()
        {
            var register = new Register();
            register.SelectedCountry = "IN";
            return View();
        }

        [HttpPost]
        public ActionResult Register(Register register)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }
            return View();
        }
    }

}