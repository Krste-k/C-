using AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Entities
{
    public class Tester : Human, ITester
    {

        public int BugFound { get; set; }   
        public Tester(string fullName, int age, long phone , int bugsFound) : base(fullName, age, phone)
        {
            BugFound = bugsFound;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {BugFound} bugs were found";
        }
        public void TestFeature(string feature)
        {
            Console.WriteLine("testing some software");
            Console.WriteLine("Oh i found a bug");
            BugFound++;
        }

      
    }
}
