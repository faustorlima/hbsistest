using System.Collections.Generic;
using HBSISTest.Application.Interfaces;
using HBSISTest.Domain.Entities;
using HBSISTest.Domain.Interfaces.Services;

namespace HBSISTest.Application
{
    public class AliquotaIrAppService : AppServiceBase<AliquotaIr>, IAliquotaIrAppService
    {
        private readonly IAliquotaIrService _aliquotaIrService;

        public AliquotaIrAppService(IAliquotaIrService aliquotaIrService) : base(aliquotaIrService)
        {
            _aliquotaIrService = aliquotaIrService;
        }
        
        public IEnumerable<AliquotaIr> GetAll()
        {
            return _aliquotaIrService.GetAll();
        }
    }
}
