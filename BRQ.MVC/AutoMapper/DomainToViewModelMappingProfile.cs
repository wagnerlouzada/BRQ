using AutoMapper;
using BRQ.Domain.Entities;
using BRQ.MVC.ViewModels;

namespace BRQ.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<GrupoDeRegrasViewModel, GrupoDeRegras>();
            CreateMap<RegraViewModel, Regra>();
            CreateMap<TradeRecordViewModel, TradeRecord>();
        }   
    }
}