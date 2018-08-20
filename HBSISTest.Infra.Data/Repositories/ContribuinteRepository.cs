using System.Collections.Generic;
using System.Linq;
using HBSISTest.Domain.Entities;
using HBSISTest.Domain.Interfaces.Repositories;

namespace HBSISTest.Infra.Data.Repositories
{
    public class ContribuinteRepository : RepositoryBase<Contribuinte>, IContribuinteRepository
    {
        public void Add(Contribuinte contribuinte)
        {
            Db.Set<Contribuinte>().Add(contribuinte);
            Db.SaveChanges();
        }

        public IEnumerable<Contribuinte> GetAll()
        {
            return Db.Set<Contribuinte>().ToList();
        }
    }
}
