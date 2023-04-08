using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses.Entities
{
    public class Dog : BaseEntity
    {
        public bool IsSeperd { get; set; }  

        public override void GetInfo()
        {
            Console.WriteLine($"Dog Info :\n Name {Name} \n Is dog a sheperd :{(IsSeperd ? "yes" : "no")}");

        }
    }
}
