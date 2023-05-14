using AutoMapper;
using ContribuyentesApi.Core.Entities;
using ContribuyentesApi.Web.DTOs;


namespace ContribuyentesApi.Web.Mappers
{
    public class ComprobanteFiscalProfile : Profile
    {
        public ComprobanteFiscalProfile()
        {
            CreateMap<ComprobanteFiscal, ComprobanteFiscalDto>()
                .ForMember(dest => dest.RncCedula, opts => opts.MapFrom(src => src.Contribuyente.RncCedula))
                .ForMember(dest => dest.Itbis, opts => opts.MapFrom(src => src.Itbis.ToString()))
                .ForMember(dest => dest.Monto, opts => opts.MapFrom(src => src.Monto.ToString()));
        }
    }
}
