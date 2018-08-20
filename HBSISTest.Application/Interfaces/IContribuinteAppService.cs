using System.Collections.Generic;
using HBSISTest.Domain.Entities;

namespace HBSISTest.Application.Interfaces
{
    public interface IContribuinteAppService : IAppServiceBase<Contribuinte>
    {
        void Add(Contribuinte contribuinte);

        IEnumerable<Contribuinte> GetAll();
    }
}
