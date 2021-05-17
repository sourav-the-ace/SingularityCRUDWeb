using LibreryAPI.APIService;
using LibreryView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibreryView.Controllers
{
    public class AddBookController : Controller
    {
        // GET: AddBook
        BookService _bs = new BookService();
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult AddBookInfo(NewBookInfo UserDataObject)
        {
            string BookName = UserDataObject.BookName;
            string BookAuthor = UserDataObject.BookAuthor;
            string BookGenre = UserDataObject.BookGenre;

            return Json(_bs.AddBookInfo(BookName, BookAuthor, BookGenre), JsonRequestBehavior.AllowGet);
        }
        

       [HttpPost]
        public JsonResult DeleteBookInfo(string id)
        {

            return Json(_bs.DeleteBookInfo(id), JsonRequestBehavior.AllowGet);
        }
        
        [HttpPost]
        public JsonResult UpdatedBookInfo(NewBookInfo UserDataObject)
        {
            string BookId = UserDataObject.id;
            string BookName = UserDataObject.BookName;
            string BookAuthor = UserDataObject.BookAuthor;
            string BookGenre = UserDataObject.BookGenre;

            return Json(_bs.UpdateBookInfo(BookId,BookName, BookAuthor, BookGenre), JsonRequestBehavior.AllowGet);
        }


    }
}