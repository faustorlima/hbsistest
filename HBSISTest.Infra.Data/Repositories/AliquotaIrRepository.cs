using System.Collections.Generic;
using System.Linq;
using HBSISTest.Domain.Entities;
using HBSISTest.Domain.Interfaces.Repositories;

namespace HBSISTest.Infra.Data.Repositories
{
    public class AliquotaIrRepository : RepositoryBase<AliquotaIr>, IAliquotaIrRepository
    {
        public IEnumerable<AliquotaIr> GetAll()
        {
            return Db.Set<AliquotaIr>().ToList();
        }
    }
}
