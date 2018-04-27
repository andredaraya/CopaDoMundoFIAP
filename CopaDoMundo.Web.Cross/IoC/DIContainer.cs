using CopaDoMundo.Web.Servico.Interfaces;
using CopaDoMundo.Web.Servico.Servicos;
using Microsoft.Extensions.DependencyInjection;

namespace CopaDoMundo.Web.Cross.IoC
{
    public static class DIContainer
    {
        public static void RegistrarDependencias(IServiceCollection services)
        {
            services.AddTransient<IJogadorServico, JogadorServico>();
            services.AddTransient<ISelecaoServico, SelecaoServico>();
        }
    }
}
