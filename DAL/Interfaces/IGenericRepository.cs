using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll(); 
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        T GetById(object id);
        void Create(T entity);
        void Update(T entity);
        void Delete(object id);

    }
}
