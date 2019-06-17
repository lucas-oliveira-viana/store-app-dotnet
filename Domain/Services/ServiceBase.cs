using Cloudmarket.Domain.Interfaces;
using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repo;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            repo = repository;
        }

        public void Add(TEntity obj)
        {
            repo.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repo.GetAll();
        }

        public TEntity GetById(int? id)
        {
            return repo.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            repo.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            repo.Update(obj);
        }

        public void Dispose()
        {
            repo.Dispose();
        }
    }
}
