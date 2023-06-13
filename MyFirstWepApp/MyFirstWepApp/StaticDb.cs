using MyFirstWepApp.Models;

namespace MyFirstWepApp
{
    public class StaticDb
    {
        public static List<Book> Books = new List<Book>()
        {
           new Book
           {
               Id = 1,
               Title = "Test",
           },
           new Book
           {
               Id = 2,
               Title = "Test",
           },
           new Book
           {
               Id = 3,
               Title = "Test",
           }
        };
    }
};
