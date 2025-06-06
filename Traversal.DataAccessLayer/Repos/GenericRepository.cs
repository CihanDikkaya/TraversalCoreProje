using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccessLayer.Abstract;
using Traversal.DataAccessLayer.Concrete;

namespace Traversal.DataAccessLayer.Repos
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        public void Delete(T t)
        {
            using var C = new Context();
            C.Remove(t);
            C.SaveChanges();
        }

        public List<T> GetList()
        {
            using var C = new Context();
            return C.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var C = new Context();
            C.Add(t);
            C.SaveChanges();

        }

        public void Update(T t)
        {
            using var C = new Context();
            C.Update(t);
            C.SaveChanges();
        }
    }
}
