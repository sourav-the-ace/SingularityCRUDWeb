using LibreryAPI.APIService;
using LibreryView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibreryView.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration

        RegistrationService _res = new RegistrationService();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult RegistrationData(Registration UserDataObject)
        {
            var Name = UserDataObject.FullName;
            var Email = UserDataObject.Email;
            var LoginName = UserDataObject.LoginName;
            var Password = UserDataObject.Password;
            var UserType = UserDataObject.UserType;

            
            return Json(_res.RegistrationInfo(Name, Email, LoginName, Password, UserType), JsonRequestBehavior.AllowGet);
        }


    }
}