using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiMenagerAplicationManagerApp9000.Domain.Entities;

namespace AplicationManagerApp9000.Services.Interfaces
{
    public interface IUserService
    {
        User? Login (string username, string password);

        bool ChangePassword(int id, string oldPasword, string newPassword);
    }
}
