using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiMenagerAplicationManagerApp9000.Domain.Enum;

namespace TaxiMenagerAplicationManagerApp9000.Domain.Entities
{
    public class Driver : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public Shift Shift { get; set; }

        public string Licence { get; set; } = string.Empty;

        public DateTime LicenceExpiryDate { get; set; }

        public Car Car { get; set; }

        public Driver(string firstname , string lastname ,Shift shift, string licence , DateTime licenceEspiryDate ,Car car )
        {
            FirstName = firstname;  
            LastName = lastname;
            Shift = shift;
            Licence = licence;
            LicenceExpiryDate = licenceEspiryDate;
            Car = car;

        }

        public override string Print()
        {
            return $"Driver {FirstName} {LastName} with license number" +
                $" {Licence} that expires on  {LicenceExpiryDate} / {LicenceExpiryDate.Year}" +
                $"drives the Car {Car.Model}.";
        }
    }
}
