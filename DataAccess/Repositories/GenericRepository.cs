using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context c = new Context();

        public List<T> GetAll()
        {
            return c.Set<T>().ToList();
        }

        public void Delete(T entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public void Update(T entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }
    }
}
