using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
     interface IRepository<T>
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T,bool>> expression);
        T Get(int id);
        T Find(Expression<Func<T, bool>> expression);
        int Add(T entity);
        int UpDate(T entity);
        int Delete(int id);
    }
}
