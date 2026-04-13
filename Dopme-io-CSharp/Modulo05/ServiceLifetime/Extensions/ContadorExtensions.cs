using Modulo05.ServiceLifetime.Services;

namespace Modulo05.ServiceLifetime.Extensions;

public static class ContadorExtensions
{
    public static IServiceCollection UseContadores(this IServiceCollection services)
    {
        services.AddSingleton<ContadorSingletonService>();
        services.AddScoped<ContadorScopedService>();
        services.AddTransient<ContadorTransienteService>();

        return services;
    }
}