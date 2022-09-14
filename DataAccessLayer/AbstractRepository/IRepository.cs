using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.AbstractRepository
{
   public interface IRepository<T> where T : class//Ben sana dışarıdan bir entity göndericem - class göndericem 
        //Her tablom için ayrı ayrı Crud işlemleri yapmak yerine tek yerden tanımlıyorum. 
    {

        int Insert(T entity);
        int Update(T entity);
        int Delete(T entity);
        List<T> GetAll(T entity);

        T GetById(int id); 
    }
}
