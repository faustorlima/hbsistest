using System.Collections.Generic;
using HBSISTest.Domain.Entities;

namespace HBSISTest.Domain.Interfaces.Repositories
{
    public interface IContribuinteRepository : IRepositoryBase<Contribuinte>
    {
        void Add(Contribuinte contribuinte);

        IEnumerable<Contribuinte> GetAll();
    }
}
