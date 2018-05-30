using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using DataLayer.Tools.Abstracts;

namespace DataLayer.Tools.Infrastructure
{
    public abstract class GenericRepository<C, T> : IGenericRepository<T> where T : class  where C : DbContext, new()
    {

        private C _entities = new C();
        public C Context
        {

            get { return _entities; }
            set { _entities = value; }
        }

        public virtual IQueryable<T> GetAll()
        {

            IQueryable<T> query = _entities.Set<T>();
            return query;
        }

        public void Delete(Guid id)
        {
            var entity = _entities.Set<T>().Find(id);
            _entities.Set<T>().Remove(entity);
        }

  

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public virtual void Add(T entity)
        {
            _entities.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Edit(T entity, params Expression<Func<T, object>>[] propsToUpdate)
        {
            _entities.Set<T>().Attach(entity);
            var entry = _entities.Entry(entity);
            foreach (var prop in propsToUpdate)
                entry.Property(prop).IsModified = true;
        }


        public virtual void Save()
        {
            _entities.SaveChanges();
        }

        public void EditAll(T[] entities)
        {
            _entities.Set<T>().AddOrUpdate(entities);
            _entities.SaveChanges();
        }
    }
}
