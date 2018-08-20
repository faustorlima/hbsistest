using System;
using System.Collections.Generic;
using HBSISTest.Domain.Entities;
using HBSISTest.Domain.Interfaces.Repositories;
using HBSISTest.Domain.Interfaces.Services;

namespace HBSISTest.Domain.Services
{
    public class ContribuinteService : ServiceBase<Contribuinte>, IContribuinteService
    {
        private readonly IContribuinteRepository _contribuinteRepository;
        private readonly ICpfService _cpfService;
        
        public ContribuinteService(IContribuinteRepository contribuinteRepository,
            ICpfService cpfService)
            : base(contribuinteRepository)  
        {
            _contribuinteRepository = contribuinteRepository;
            _cpfService = cpfService;
        }

        public void Add(Contribuinte contribuinte)
        {
            if(!_cpfService.IsValid(contribuinte.Cpf))
                throw new Exception(string.Format("CPF {0} inválido", contribuinte.Cpf));
            
            _contribuinteRepository.Add(contribuinte);
        }

        public IEnumerable<Contribuinte> GetAll()
        {
            return _contribuinteRepository.GetAll();
        }
    }
}
