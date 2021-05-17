using LibreryAPI.APIService;
using LibreryView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibreryView.Controllers
{
    public class LoginController : Controller
    {

        LoginService _lg = new LoginService();
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public JsonResult LoginData(Login UserDataObject)
        {
            string email = UserDataObject.email;
            string password = UserDataObject.password;

            return Json(_lg.LoginUser(email, password), JsonRequestBehavior.AllowGet);
        }


        public ActionResult Logout()
        {
            Session["userLoginName"] = null;
            return RedirectToAction("Login", "Login");
        }
    }
}