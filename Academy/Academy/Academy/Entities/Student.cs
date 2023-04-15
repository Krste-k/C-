using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Entities
{
    public class Student : BaseEntry
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        bool IsPartTime { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student(int id , string firstName , string lastName , int age , bool isPartTime)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IsPartTime = isPartTime;
            Subjects = new List<Subject>();           
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} aged {Age} attends {Subjects.Count} number of subjects");
        }
    }
}
