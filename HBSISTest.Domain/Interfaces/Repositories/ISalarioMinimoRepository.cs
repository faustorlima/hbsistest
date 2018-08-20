using HBSISTest.Domain.Entities;

namespace HBSISTest.Domain.Interfaces.Repositories
{
    public interface ISalarioMinimoRepository : IRepositoryBase<SalarioMinimo>
    {
        void Update(SalarioMinimo salarioMinimo);

        SalarioMinimo GetById(int id);
    }
}
