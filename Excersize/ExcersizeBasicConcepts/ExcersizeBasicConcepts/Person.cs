using ExcersizeBasicConcepts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersizeBasicConcepts
{
    public class Person : Client
    {
        private int _monthlyWage;

        public string FirstName { get; set; }   
        public string LastName { get; set; } 
        public int Age { get; set; }
        private int _ssn { get; set; }
        public Ocupation Occupation { get; set; }
        private int _montlyWage { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Person() 
        {
        
        }
        public Person(string firstName, string lastName, int age, int ssn ,Ocupation occupation ) 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            _ssn = ssn;
            Mobile = Mobile;
            Address = Address;
            State = State;
            Phone = Phone;
            Email = Email;
            Occupation = occupation;

        }
        public void OccupationCheck(int age)
        {
            if (age < 16)
            {
                Console.WriteLine("Error under 16");
            }
            else if (age < 18)
            {
                Console.WriteLine(Ocupation.Student);
            }
            else if (age > 65)
            {
                Console.WriteLine(Ocupation.Retired);
            }
            else
            {
                Console.WriteLine(Ocupation.DataEngineer);
            }
        }
        public bool HasDepositProduct { get; set; }


        public void CheckCandidate()
        {
            bool isGoodCandidate;
            if (_monthlyWage > 18000 && Age > 25 && Age < 60)
            {
                isGoodCandidate = true;
            }
        }
        public bool IsLoanCandidate()
        {
            bool hasDeposit = false;
            foreach (var product in Products)
            {
                Product product1 = product;
                if (product1 == " ")
                {
                    hasDeposit = true;
                    break;
                }
            }
            if (_monthlyWage > 18000 && Age > 25 && Age < 60 && hasDeposit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void generateSSN()
        {
            int random = new Random().Next(1000, 9999);
            _ssn = (int)random;
        }
    }
}
