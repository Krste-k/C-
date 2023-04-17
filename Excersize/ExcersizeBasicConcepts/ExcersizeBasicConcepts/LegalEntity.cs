using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersizeBasicConcepts
{
    public class LegalEntity : Client
    {
        public string Name { get; set; }

        private int _taxNum {  get; set; }
        public int EmployeeNum { get; set; }
        private int Profit { get; set; }
        public enum _activity
        {
            Manufacture,
            FoodProduction,
            Accounting,
            Clothing,
            Entertainment,
            Esports
        }

     public List<string> Owener { get; set; }
        
        public void GenerateTax()
        {
            int random = new Random().Next(1000,999);
            _taxNum = (int)random;
        }
    }
}
