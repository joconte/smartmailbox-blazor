using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using SmartMailBoxLib;

namespace Blazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSmartMailboc();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
