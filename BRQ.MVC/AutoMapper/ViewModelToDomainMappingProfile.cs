using AutoMapper;
using BRQ.Domain.Entities;
using BRQ.MVC.ViewModels;

namespace BRQ.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<GrupoDeRegras, GrupoDeRegrasViewModel>();
            CreateMap<Regra, RegraViewModel>();
            CreateMap<TradeRecord, TradeRecordViewModel>();
        }
    }
}