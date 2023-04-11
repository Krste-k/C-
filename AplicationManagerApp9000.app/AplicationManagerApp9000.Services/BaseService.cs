using AplicationManagerApp9000.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiMenagerAplicationManagerApp9000.DataAcces;
using TaxiMenagerAplicationManagerApp9000.DataAcces.Interfaces;
using TaxiMenagerAplicationManagerApp9000.Domain.Entities;

namespace AplicationManagerApp9000.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        protected IDb<T> Db;

        public BaseService()
        {
            Db = new LocalDb<T>();
        }
        public bool Add(T entity)
        {
            try
            {
                Db.Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<T> GetAll()
        {
            return Db.GetAll();
        }

        public T GetById(int id)
        {
            return Db.GetById(id);
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }

    
    }

    
}
