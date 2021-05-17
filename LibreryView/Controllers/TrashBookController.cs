using LibreryAPI.APIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibreryView.Controllers
{
    public class TrashBookController : Controller
    {
        // GET: TrashBook

        TrashBookService _tbs = new TrashBookService();
        public ActionResult Index()
        {
            return View();
        }

        
        public JsonResult TrashBookList()
        {
            return Json(_tbs.TrashBookList(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult RestoreTrashBook(string id)
        {
            return Json(_tbs.RestoreTrashBook(id), JsonRequestBehavior.AllowGet);
        }
    }
}