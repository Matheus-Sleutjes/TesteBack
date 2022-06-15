using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics.CodeAnalysis;
using TesteBack.Repository;
using TesteBack.Repository.Interface;
using TesteBack.Service;
using TesteBack.Service.Interface;

namespace TesteBack.Configuration
{
    [ExcludeFromCodeCoverage]
    public static class DependencyConfig
    {
        public static void DependencyRegister(this IServiceCollection services)
        {
            services.AddScoped<IMoedaService, MoedaService>();
            services.AddScoped<IMoedaRepository, MoedaRepository>();

            services.AddScoped<IConverter, Converter>();
        }
    }
}
