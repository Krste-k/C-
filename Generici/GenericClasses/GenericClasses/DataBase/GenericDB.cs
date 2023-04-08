using GenericClasses.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses.DataBase
{
    public static class GenericDB<T> where T : BaseEntity
    {
        public static List<T> Db;

        static GenericDB()
        {
        Db = new List<T>();
        }

        public static void PrintAll()
        {
            foreach (T item in Db)
            {
                item.GetInfo();
            }
        }
        public static void Insert(T item)
        {
            Db.Add(item);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine($"The item {item.GetType().Name} Was added to the GenericDb");
            Console.ResetColor();
        }
        public static T GetById(int id) => Db.FirstOrDefault(x => x.Id == id);
    }
    

}
