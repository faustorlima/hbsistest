using System.Collections.Generic;
using System.Linq;
using HBSISTest.Application.Interfaces;
using HBSISTest.Domain.Entities;
using HBSISTest.Domain.Interfaces.Services;

namespace HBSISTest.Application
{
    public class ContribuinteAppService : AppServiceBase<Contribuinte>, IContribuinteAppService
    {
        private readonly IContribuinteService _contribuinteService;
        private readonly IAliquotaIrService _aliquotaIrService;
        private readonly ISalarioMinimoService _salarioMinimoService;

        public ContribuinteAppService(IContribuinteService contribuinteService, 
            IAliquotaIrService aliquotaIrService,
            ISalarioMinimoService salarioMinimoService) : base(contribuinteService)
        {
            _contribuinteService = contribuinteService;
            _aliquotaIrService = aliquotaIrService;
            _salarioMinimoService = salarioMinimoService;
        }

        public void Add(Contribuinte contribuinte)
        {
            _contribuinteService.Add(contribuinte);
        }

        public IEnumerable<Contribuinte> GetAll()
        {
            // Get contribuintes
            IEnumerable<Contribuinte> contribuintes = _contribuinteService.GetAll();

            IEnumerable<AliquotaIr> aliquotaIrs = _aliquotaIrService.GetAll();

            // Get Salário Mínimo
            SalarioMinimo salarioMinimo = _salarioMinimoService.GetById(1);


            foreach (var contribuinte in contribuintes)
            {
                decimal rendaLiquida = contribuinte.RendaBrutaMensal -
                                         (contribuinte.NumeroDependentes *
                                          (salarioMinimo.Salario * (decimal) 0.05));

                double qtdSalariosMinimos = (double)(rendaLiquida / salarioMinimo.Salario);

                AliquotaIr aliquotaIr = aliquotaIrs.Where(a => a.DeSalariosMinimos <= qtdSalariosMinimos
                                                               && (a.AteSalariosMinimos >= qtdSalariosMinimos || a.AteSalariosMinimos == null )).First();

                contribuinte.ImpostoRenda = (rendaLiquida * (decimal)aliquotaIr.Aliquota)/100;
            }

            // Get Aliquotas IR

            return contribuintes.OrderBy(c => c.ImpostoRenda).ThenBy(c => c.Nome);
        }
    }
}
