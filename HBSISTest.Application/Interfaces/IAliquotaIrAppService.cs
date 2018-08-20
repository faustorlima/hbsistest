using System.Collections.Generic;
using HBSISTest.Domain.Entities;

namespace HBSISTest.Application.Interfaces
{
    public interface IAliquotaIrAppService : IAppServiceBase<AliquotaIr>
    {
        IEnumerable<AliquotaIr> GetAll();
    }
}
