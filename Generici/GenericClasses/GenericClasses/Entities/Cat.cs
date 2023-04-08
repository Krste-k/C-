using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses.Entities
{
    internal class Cat : BaseEntity
    {
        public bool IsNice { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"Cat Info :\n Name {Name} \n Is nice :{(IsNice ? "yes" : "no")}");

        }
    }
}
