using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaDoMundo.Web.Cross.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CopaDoMundo.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            ConfigureMap.Configure();
        }

        

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc();

            //Injeção de independencia (serviços)
            DIContainer.RegistrarDependencias(services);
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
    }
}
