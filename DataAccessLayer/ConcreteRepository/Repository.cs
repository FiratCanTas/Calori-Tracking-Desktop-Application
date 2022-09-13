using DataAccessLayer.AbstractRepository;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.ConcreteRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        FatHunterDbContext dbContext = new FatHunterDbContext();

        DbSet<T> _object;

        public Repository()
        {
            _object = dbContext.Set<T>();
        }

        public int Delete(T entity)
        {
            _object.Remove(entity);
            return dbContext.SaveChanges();
        }

        public List<T> GetAll(T entity)
        {
            return _object.ToList();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T entity)
        {
            _object.Add(entity);
            return dbContext.SaveChanges();
        }

        public int Update(T entity)
        {
            return dbContext.SaveChanges();
        }
    }
}
