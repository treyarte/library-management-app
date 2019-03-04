using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using library_management_app.Data;
using library_management_app.Models;

namespace library_management_app.Controllers
{
    public class BooksController : Controller
    {
        private BookRepository _bookRepository = null;

        //initialize the book repo to get the book the data
        public BooksController()
        {
            _bookRepository = new BookRepository();
        }
        // GET: Books
        public ActionResult Index()
        {
            Book[] books = _bookRepository.GetBooks();

            return View(books);
        }

        //GET a Book
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var book = _bookRepository.GetBook(id.Value);
            return View(book);
        }
    }
}