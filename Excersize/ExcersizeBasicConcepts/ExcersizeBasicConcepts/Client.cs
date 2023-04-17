using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersizeBasicConcepts
{
    public class Client
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }


        public string EmailCheck(string email)
        {
            if (email.Contains(".com") && !email.Contains("@"))
            {
                Console.WriteLine("Invalid Email.Must contain @ .com");
            }
            return email;
        }
        public string PhoneCheck(string number)
        {
            if (!number.StartsWith("07"))
            {
                Console.WriteLine("Number must start with 07");
            }
            return number;
        }
    }
}