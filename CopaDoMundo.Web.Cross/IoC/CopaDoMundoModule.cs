using Autofac;
using CopaDoMundo.Web.Servico.Interfaces;
using CopaDoMundo.Web.Servico.Options;
using CopaDoMundo.Web.Servico.Servicos;
using Microsoft.Extensions.Configuration;

namespace CopaDoMundo.Web.Cross.IoC
{
    public class CopaDoMundoModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            RegistrarDependencias(builder);
            base.Load(builder);
        }

        public static void RegistrarDependencias(ContainerBuilder builder)
        {
            #region [Registra ServicoSelecao]
            builder.Register(ctx => new SelecaoOptions(ctx.Resolve<IConfiguration>()))
                       .As<SelecaoOptions>()
                       .SingleInstance()
                       .AutoActivate();

            builder.Register(ctx => new SelecaoServico(ctx.Resolve<SelecaoOptions>()))
                   .As<ISelecaoServico>()
                   .SingleInstance()
                   .AutoActivate();
            #endregion

            #region [Registra JogadorSelecao]
            builder.Register(ctx => new JogadorOptions(ctx.Resolve<IConfiguration>()))
                       .As<JogadorOptions>()
                       .SingleInstance()
                       .AutoActivate();

            builder.Register(ctx => new JogadorServico(ctx.Resolve<JogadorOptions>()))
                   .As<IJogadorServico>()
                   .SingleInstance()
                   .AutoActivate();
            #endregion


        }
    }
}
