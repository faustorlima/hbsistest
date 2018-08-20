using HBSISTest.Application.Interfaces;
using HBSISTest.Domain.Entities;
using HBSISTest.Domain.Interfaces.Services;

namespace HBSISTest.Application
{
    public class SalarioMinimoAppService : AppServiceBase<SalarioMinimo>, ISalarioMinimoAppService
    {
        private readonly ISalarioMinimoService _salarioMinimoService;

        public SalarioMinimoAppService(ISalarioMinimoService salarioMinimoService) : base(salarioMinimoService)
        {
            _salarioMinimoService = salarioMinimoService;
        }

        public void Update(SalarioMinimo salarioMinimo)
        {
            _salarioMinimoService.Update(salarioMinimo);
        }

        public SalarioMinimo GetById(int id)
        {
            return _salarioMinimoService.GetById(id);
        }
    }
}
