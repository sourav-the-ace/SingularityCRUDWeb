using LibreryAPI.APIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibreryView.Controllers
{
    public class TrashUserController : Controller
    {
        // GET: TrashUser
        TrashUserService _tus = new TrashUserService();
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult TrashUserList()
        {
            return Json(_tus.TrashUserList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult RestoreTrashUser(string id)
        {
            return Json(_tus.RestoreTrashUser(id), JsonRequestBehavior.AllowGet);
        }
    }
}