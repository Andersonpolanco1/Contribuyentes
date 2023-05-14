using AutoMapper;
using ContribuyentesApi.Core.Entities;
using ContribuyentesApi.Web.DTOs;


namespace ContribuyentesApi.Web.Mappers
{
    public class ContribuyenteProfile : Profile
    {
        public ContribuyenteProfile()
        {
            CreateMap<Contribuyente, ContribuyenteDto>()
                .ForMember(dest => dest.Tipo, opts => opts.MapFrom(src => src.TipoContribuyente.Descripcion))
                .ForMember(dest => dest.Estatus, opts => opts.MapFrom(src => src.EstaActivo ? "activo" : "inactivo"));
        }
    }
}
