using System;
using HBSISTest.Application.Interfaces;
using HBSISTest.Domain.Interfaces.Services;

namespace HBSISTest.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
