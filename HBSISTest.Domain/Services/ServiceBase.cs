using System;
using HBSISTest.Domain.Interfaces.Repositories;
using HBSISTest.Domain.Interfaces.Services;

namespace HBSISTest.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

    }
}
