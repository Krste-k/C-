using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiMenagerAplicationManagerApp9000.Domain.Enum;

namespace TaxiMenagerAplicationManagerApp9000.Domain.Entities
{
    public class User : BaseEntity
    {

        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public Role Role { get; set; }
        public string Username { get; set; }

        public User( string username,string password,Role role)
        {
            UserName = username;
            Password = password;
            Role = role;
        }
        public override string Print()

        {
            return $"User With username: {UserName} and role: [{Role}]";

        }
    }
}
