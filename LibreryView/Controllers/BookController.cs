using LibreryAPI.APIService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibreryView.Controllers
{
    public class BookController : Controller
    {
        BookService _bs = new BookService();
        public ActionResult Index()
        {
            if(Session["userLoginName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
            
            
        }

        public JsonResult BookList()
        {
            return Json(_bs.BookList(), JsonRequestBehavior.AllowGet);
        }
    }
}