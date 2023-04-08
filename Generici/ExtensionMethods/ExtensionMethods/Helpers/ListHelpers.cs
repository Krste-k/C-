using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Helpers
{
    public static class ListHelpers
    {
        public static void Print<T>(this List<T>  items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
        public static void GetInfo<T>(this List<T> items)
        {
            Console.WriteLine($"This List has {items.Count} members and is type of {items.GetType()}");
        }

        public static string CapitalizeFirstLetter (this string word, string name)
        {
            string text = char.ToUpper(word[0] ) + word.Substring(1) + name;
            return text;
        }
        public static void ColorText(this string text,ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
