using System.Collections.Generic;
using HBSISTest.Domain.Entities;

namespace HBSISTest.Domain.Interfaces.Repositories
{
    public interface IAliquotaIrRepository : IRepositoryBase<AliquotaIr>
    {
        IEnumerable<AliquotaIr> GetAll();
    }
}
