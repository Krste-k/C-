using Microsoft.AspNetCore.Mvc;
using MyFirstWepApp.Models;

namespace MyFirstWepApp.Controllers
{

    public class BookController : Controller
    {

        //https://localhost:7210/book/index
        public IActionResult Index()
        {
            List<Book> books = StaticDb.Books;    
            return View();
        }

        //https://localhost:7210/book/Empty
        public IActionResult Empty ()
        { 
            return new EmptyResult();
        }

        //https://localhost:7210/book/GetJson
        [Route("Json")]
        public IActionResult GetJson() 
        {
            Book book = new Book()
            {
                Id = 1,
                Title = "Kasni porasni"
            };
            return new JsonResult(book);
        }

        //https://localhost:7210/book/Redirect
        public IActionResult Redirect ()
        {
            return RedirectToAction ("Index");
        }

        public IActionResult SecondRedirect()
        {
            return RedirectToAction("Privacy" , "Home");
        }
        public IActionResult Details (int? id)
        {
            if (id == null )
            {
                return new EmptyResult ();
            }
            return View();
        }
        Book book = StaticDb.Books.FirstOrDefault(book => book.Id == id);
        private static int id;
    }
}
