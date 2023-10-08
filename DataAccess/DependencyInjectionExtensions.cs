using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;
public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddDataAccessLayer(this IServiceCollection services)
    {
        return services;
    }
}
