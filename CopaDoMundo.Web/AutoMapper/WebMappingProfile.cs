using AutoMapper;
using CopaDoMundo.Web.Servico.DTO;
using CopaDoMundo.Web.ViewModels;

namespace CopaDoMundo.Web.AutoMapper
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<JogadorDTO, JogadorViewModel>()
                .ReverseMap().ForMember(dto => dto.CriadoEm, opt => opt.Ignore());
            CreateMap<SelecaoDTO, SelecaoViewModel>()
                .ReverseMap()
                .ForMember(dto => dto.CriadoEm, opt => opt.Ignore());
        }
    }
}
