using HBSISTest.Domain.Entities;

namespace HBSISTest.Domain.Interfaces.Services
{
    public interface ISalarioMinimoService : IServiceBase<SalarioMinimo>
    {
        void Update(SalarioMinimo salarioMinimo);

        SalarioMinimo GetById(int id);
    }
}
