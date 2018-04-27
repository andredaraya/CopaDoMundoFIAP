using AutoMapper;
using CopaDoMundo.Web.Servico.DTO;
using CopaDoMundo.Web.ViewModels;
using CopaDoMundo.Web.Extensoes;
using CopaDoMundo.Web.Enum;

namespace CopaDoMundo.Web.AutoMapper
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<JogadorDTO, JogadorViewModel>()
                .ForMember(vw => vw.Selecoes, opt => opt.Ignore())
                .ForMember(vw => vw.Posicao, map => map.MapFrom(x=>x.Posicao.GetValueFromDescription<ePosicao>()));
            CreateMap<JogadorViewModel,JogadorDTO >()
                .ForMember(dto => dto.CriadoEm, opt => opt.Ignore());

            CreateMap<SelecaoDTO, SelecaoViewModel>();

            CreateMap<SelecaoViewModel, SelecaoDTO>()
                .ForMember(dto => dto.CriadoEm, opt => opt.Ignore());
        }
    }
}
