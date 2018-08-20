using System.Collections.Generic;
using HBSISTest.Domain.Entities;
using HBSISTest.Domain.Interfaces.Repositories;
using HBSISTest.Domain.Interfaces.Services;

namespace HBSISTest.Domain.Services
{
    public class AliquotaIrService : ServiceBase<AliquotaIr>, IAliquotaIrService
    {
        private readonly IAliquotaIrRepository _aliquotaIrRepository;

        public IEnumerable<AliquotaIr> GetAll()
        {
            return _aliquotaIrRepository.GetAll();
        }

        public AliquotaIrService(IAliquotaIrRepository aliquotaIrRepository) : base(aliquotaIrRepository)
        {
            _aliquotaIrRepository = aliquotaIrRepository;
        }
    }
}
