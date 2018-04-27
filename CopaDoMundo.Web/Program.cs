using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CopaDoMundo.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                 .UseKestrel()
                 .UseContentRoot(Directory.GetCurrentDirectory())
                 .ConfigureAppConfiguration((hostingContext, config) =>
                 {
                     var env = hostingContext.HostingEnvironment;

                     config.AddJsonFile("appsettings.json", optional: true)
                         .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

                     config.AddEnvironmentVariables();
                 })
                 .UseIISIntegration()
                 .UseStartup<Startup>()
                 .UseApplicationInsights()
                 .Build();

            host.Run();
        }
    }
}
