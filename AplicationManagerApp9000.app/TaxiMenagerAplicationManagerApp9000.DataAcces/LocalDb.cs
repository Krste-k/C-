using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiMenagerAplicationManagerApp9000.DataAcces.Interfaces;
using TaxiMenagerAplicationManagerApp9000.Domain.Entities;

namespace TaxiMenagerAplicationManagerApp9000.DataAcces
{
    public class LocalDb<T> : IDb<T> where T : BaseEntity
    {

        public int IdCounter { get; set; }

        private List<T> db ;

        public LocalDb()
        {
            db = new List<T>();
            IdCounter = 1;
        }
        public int Add(T entity)
        {
            entity.Id = IdCounter++;
            db.Add(entity);

            return entity.Id;
        }

        public List<T> GetAll()
        {
            return db;
        }

        public T GetById(int id)
        {
          return db.Single(x => x.Id == id);
        }

        public bool RemoveById(int id)
        {
            try
            {
                T entiti = GetById(id);
                db.Remove(entiti);
                return true;
            }
            catch (Exception ex ) 
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                T DbEntity = GetById(entity.Id);
                DbEntity = entity;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

