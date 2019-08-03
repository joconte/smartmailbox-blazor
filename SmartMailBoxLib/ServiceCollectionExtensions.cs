using Microsoft.Extensions.DependencyInjection;
using SmartMailBoxLib.REST;
using SmartMailBoxLib.Services;

namespace SmartMailBoxLib
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSmartMailboc(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<RestService>();
            serviceCollection.AddScoped<AccountServiceManager>();
            serviceCollection.AddScoped<AccountServiceApi>();
            return serviceCollection;
        }
    }
}
