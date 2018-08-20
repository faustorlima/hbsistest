using AutoMapper;
using HBSISTest.Domain.Entities;
using HBSISTest.WebAPI.ViewModels;

namespace HBSISTest.WebAPI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ContribuinteViewModel, Contribuinte>();
            Mapper.CreateMap<AliquotaIrViewModel, AliquotaIr>();
            Mapper.CreateMap<SalarioMinimoViewModel, SalarioMinimo>();
        }
    }
}