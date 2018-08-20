using System.Collections.Generic;
using HBSISTest.Domain.Entities;

namespace HBSISTest.Domain.Interfaces.Services
{
    public interface IAliquotaIrService : IServiceBase<AliquotaIr>
    {
        IEnumerable<AliquotaIr> GetAll();
    }
}
