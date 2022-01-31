using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace APIControleOrçamento.Repositories.Interfaces
{
    public interface IRepository<T> where T: class
    {
        Task<List<T>> Get();
        Task<T> GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}