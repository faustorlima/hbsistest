using System;
using HBSISTest.Domain.Interfaces.Repositories;
using HBSISTest.Infra.Data.Context;

namespace HBSISTest.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected HBSISTestContext Db = new HBSISTestContext();

        public void Dispose()
        {
        }
    }
}
