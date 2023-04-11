using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiMenagerAplicationManagerApp9000.Domain.Entities;

namespace TaxiMenagerAplicationManagerApp9000.DataAcces.Interfaces
{
    public interface IDb<T> where T : BaseEntity
    {
        int Add(T entity);

        bool RemoveById (int id);

        bool Update (T entity);

        List<T> GetAll ();

        T GetById (int id);

    }
}
