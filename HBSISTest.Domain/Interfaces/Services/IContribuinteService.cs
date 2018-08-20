using HBSISTest.Domain.Entities;
using System.Collections.Generic;

namespace HBSISTest.Domain.Interfaces.Services
{
    public interface IContribuinteService : IServiceBase<Contribuinte>
    {
        void Add(Contribuinte contribuinte);
        
        IEnumerable<Contribuinte> GetAll();
    }
}
