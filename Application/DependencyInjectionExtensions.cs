using Microsoft.Extensions.DependencyInjection;

namespace Application;
public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        return services;
    }
}
