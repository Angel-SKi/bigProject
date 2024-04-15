using AutoMapper.Configuration.Annotations;
using DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly BigProjectDBContext _context;

        public GenericRepository(BigProjectDBContext context)
        {
           _context = context;
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
           
        }

        public void Delete(object id)
        {
            var entityToDelete = _context.Set<T>().Find(id);
            _context.Remove(entityToDelete);
            _context.SaveChanges();
            
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            if(entity != null) 
            { 
                _context.Update(entity);
             
                _context.SaveChanges();
            }

        }
    }
}
