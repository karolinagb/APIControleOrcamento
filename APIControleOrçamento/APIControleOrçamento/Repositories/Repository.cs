using APIControleOrçamento.Data;
using APIControleOrçamento.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIControleOrçamento.Repositories
{
    public class Repository<T> : IRepository<T> where T : class //T (tipo genérico) só pode ser uma classe
    {
        protected APIControleOrcamentoContext _context;

        public Repository(APIControleOrcamentoContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
