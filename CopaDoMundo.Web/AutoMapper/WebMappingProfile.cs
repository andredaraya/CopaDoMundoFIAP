using AutoMapper;
using CopaDoMundo.Model;
using CopaDoMundo.Web.ViewModels;

namespace CopaDoMundo.Web.AutoMapper
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<Jogador, JogadorViewModel>()
                .ForMember(vw => vw.SelecaoEscolhida, opt => opt.Ignore())
                .ForMember(vw => vw.Selecoes, opt => opt.Ignore());
            CreateMap<JogadorViewModel,Jogador >()
                .ForMember( jogador => jogador.CriadoEm, opt => opt.Ignore());

            CreateMap<Selecao, SelecaoViewModel>();

            CreateMap<SelecaoViewModel, Selecao>()
                .ForMember(jogador => jogador.CriadoEm, opt => opt.Ignore());
        }
    }
}
