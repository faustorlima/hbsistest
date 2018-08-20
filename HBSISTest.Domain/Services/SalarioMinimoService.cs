using HBSISTest.Domain.Entities;
using HBSISTest.Domain.Interfaces.Repositories;
using HBSISTest.Domain.Interfaces.Services;

namespace HBSISTest.Domain.Services
{
    public class SalarioMinimoService : ServiceBase<SalarioMinimo>, ISalarioMinimoService
    {
        private readonly ISalarioMinimoRepository _salarioMinimoRepository;
        
        public SalarioMinimoService(ISalarioMinimoRepository salarioMinimoRepository) : base(salarioMinimoRepository)
        {
            _salarioMinimoRepository = salarioMinimoRepository;
        }

        public void Update(SalarioMinimo salarioMinimo)
        {
            _salarioMinimoRepository.Update(salarioMinimo);
        }

        public SalarioMinimo GetById(int id)
        {
            return _salarioMinimoRepository.GetById(id);
        }
    }
}
