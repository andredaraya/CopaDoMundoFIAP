using Autofac;
using Autofac.Extensions.DependencyInjection;
using CopaDoMundo.Web.AutoMapper;
using CopaDoMundo.Web.Cross.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace CopaDoMundo.Web
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            ConfiguracaoMap.Configure();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc();

            var builder = new ContainerBuilder();
            builder.Register<IConfiguration>(x => Configuration);
            builder.Populate(services);

            var appContainer = InitializeContainer(builder);

            return appContainer.Resolve<IServiceProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(builder => builder.AllowAnyHeader()
                                         .AllowAnyMethod()
                                         .AllowAnyOrigin());

            app.UseExceptionHandler("/Home/Error");

            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                //app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                     name: "Jogadores",
                     template: "Jogadores/{id?}",
                     defaults: new { controller = "Jogadores", action = "Index" });
                routes.MapRoute(
                      name: "Selecoes",
                      template: "Selecoes/{id?}",
                      defaults: new { controller = "Selecoes", action = "Index" });
            });
        }

        private IContainer InitializeContainer(ContainerBuilder builder)
        {
            var copaDoMundoAssembly = typeof(CopaDoMundoModule).GetTypeInfo().Assembly;
            builder.RegisterAssemblyModules(copaDoMundoAssembly);
            return builder.Build();
        }
    }
}
