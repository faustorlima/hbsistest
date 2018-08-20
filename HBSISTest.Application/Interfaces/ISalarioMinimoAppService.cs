using HBSISTest.Domain.Entities;

namespace HBSISTest.Application.Interfaces
{
    public interface ISalarioMinimoAppService : IAppServiceBase<SalarioMinimo>
    {
        void Update(SalarioMinimo salarioMinimo);

        SalarioMinimo GetById(int id);
    }
}
