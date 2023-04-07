using AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Entities
{
    public class DevOps : Human, IDeveloper, IDevOps
    {
        public bool AWSCertified { get; set; }  
        public bool AzureCertified { get; set; }

        public DevOps(string fullName, int age, long phone, bool aWSCertified, bool azureCertified) : base(fullName , age ,phone) 
        {
            AWSCertified = aWSCertified;
            AzureCertified = azureCertified;
        }

        public bool CheckInfrastructure(int status)
        {
            List<int> OkStatus = new List<int>() { 200,202,204};
            if (OkStatus.Contains(status))
            {
                return true;
            }
            return false;
        }

        public void Code()
        {
            Console.WriteLine("The DevOps guy is coding,but not like the developer one ");
        }
        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - AWS Certified: {(AWSCertified ? "yes" : "No")} Azure Certifirf : {(AzureCertified ? "yes" : "no")}";
        }
    }
}
