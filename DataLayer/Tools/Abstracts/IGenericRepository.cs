using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Tools.Abstracts
{
    public interface IGenericRepository<T> where T : class
    {

        IQueryable<T> GetAll();
        IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Delete(T entity);

        void Edit(T entity);

        void Edit(T entity, params Expression<Func<T, object>>[] propsToUpdate);
        void Save();

        void Delete(Guid id);
        void EditAll(T[] entities);
    }
}
