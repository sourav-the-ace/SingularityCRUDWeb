using LibreryAPI.APIService;
using LibreryView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibreryView.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserService _usr = new UserService();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetUserList()
        {
            return Json(_usr.GetUserList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteUserInfo(string id)
        {
            return Json(_usr.DeleteUserInfo(id), JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult UpdatedUserInfo(Registration UserDataObject)
        {
            string UserId = UserDataObject.Id;
            string FullName = UserDataObject.FullName;
            string Email = UserDataObject.Email;
            string LoginName = UserDataObject.LoginName;


            return Json(_usr.UpdatedUserInfo(UserId, FullName, Email, LoginName), JsonRequestBehavior.AllowGet);
        }
    }
}