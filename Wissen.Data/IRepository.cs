using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Wissen.Model;

namespace Wissen.Data
{
  public  interface IRepository<T> where T : BaseEntity
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> where);//predidate kullanımı 
        //linq da kullanıcagın koşul..
        T Find(Expression<Func<T, bool>> where);
        T Find(int id);
        void SaveChanges();
       

    }
}
