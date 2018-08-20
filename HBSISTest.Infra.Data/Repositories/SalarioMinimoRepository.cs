using System.Data.Entity;
using HBSISTest.Domain.Entities;
using HBSISTest.Domain.Interfaces.Repositories;

namespace HBSISTest.Infra.Data.Repositories
{
    public class SalarioMinimoRepository : RepositoryBase<SalarioMinimo>, ISalarioMinimoRepository
    {
        public void Update(SalarioMinimo salarioMinimo)
        {
            Db.Entry(salarioMinimo).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public SalarioMinimo GetById(int id)
        {
            return Db.Set<SalarioMinimo>().Find(id);
        }
    }
}
