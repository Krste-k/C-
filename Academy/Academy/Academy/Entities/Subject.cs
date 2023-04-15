using Academy.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Entities
{
    public class Subject : BaseEntry
    {
        public string Title { get; set; } = string.Empty;
 
        public int Moduls { get; set; }
        public int StudentsAttending { get; set; }
        public AcademyType AcademyType { get; set; }

        public Subject(int id, string title ,int moduls , int studentsAttending , AcademyType academyType)
        {
            Id = id;
            Title = title;
            Moduls = moduls;
            StudentsAttending = studentsAttending;
            AcademyType = academyType;           
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"{Title} has {Moduls} number of mosules, Academy - {AcademyType}");
        }
    }
}
