using AutoMapper;

namespace CopaDoMundo.Web.AutoMapper
{
    public static class ConfiguracaoMap
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<WebMappingProfile>();
            });
        }
    }
}
