using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Repository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private DatabaseContext context;
        private DbSet<T> _objectSet;
        public Repository()
        {
            if (context == null)
            {
                context = new DatabaseContext();
                _objectSet = context.Set<T>();
            }
        }
        public int Add(T entity)
        {
            _objectSet.Add(entity);
            return context.SaveChanges();
        }

        public int Delete(int id)
        {
            _objectSet.Remove(Get(id));
            return context.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> expression)
        {
            return _objectSet.FirstOrDefault(expression);
        }

        public T Get(int id)
        {
            return _objectSet.Find(id);
        }

        public List<T> GetAll()
        {
            return _objectSet.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _objectSet.Where(expression).ToList();
        }

        public int UpDate(T entity)
        {
            _objectSet.AddOrUpdate(entity);
            return context.SaveChanges();
        }
    }
}
