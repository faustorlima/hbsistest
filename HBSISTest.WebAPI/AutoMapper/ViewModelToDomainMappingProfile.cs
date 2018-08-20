using AutoMapper;
using HBSISTest.Domain.Entities;
using HBSISTest.WebAPI.ViewModels;

namespace HBSISTest.WebAPI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Contribuinte, ContribuinteViewModel>();
            Mapper.CreateMap<AliquotaIr, AliquotaIrViewModel>();
            Mapper.CreateMap<SalarioMinimo, SalarioMinimoViewModel>();
        }
    }
}