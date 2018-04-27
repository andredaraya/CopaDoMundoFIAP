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
                .ForMember(vw => vw.SelecaoEscolhida, opt => opt.Ignore())
                .ForMember(vw => vw.Selecoes, opt => opt.Ignore());
            CreateMap<JogadorViewModel,JogadorDTO >()
                .ForMember(dto => dto.CriadoEm, opt => opt.Ignore());

            CreateMap<SelecaoDTO, SelecaoViewModel>();

            CreateMap<SelecaoViewModel, SelecaoDTO>()
                .ForMember(dto => dto.CriadoEm, opt => opt.Ignore());
        }
    }
}
