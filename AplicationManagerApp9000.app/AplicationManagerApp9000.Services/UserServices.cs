using AplicationManagerApp9000.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TaxiMenagerAplicationManagerApp9000.Domain.Entities;

namespace AplicationManagerApp9000.Services
{
    public class UserServices : BaseService<User>, IUserService
    {
        public bool ChangePassword(int id, string oldPasword, string newPassword)
        {
            User user = Db.GetById(id);

            if (user == null)
            {
                throw new Exception();
            }
            if (user)
        }

        public User? Login(string username, string password)
        {
            User user = Db.GetAll().FirstOrDefault(x => x.Username == username && x.Password == pas )
        }
    }
}
