using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.Repositories
{
    public class CategoryRepository<T> : IRepository<T> where T : class
    {
        Context context = new Context();
        DbSet<T> _object;
        public void Delete(T p)
        {
            _object.Remove(p);
        }
        public void Insert(T p)
        {
            _object.Add(p);
            context.SaveChanges();
        }
        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            context.SaveChanges();
        }

    }
}
