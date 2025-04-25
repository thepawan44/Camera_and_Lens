using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using UI.Shared.Component.Base;
using UI.Shared.Component.Icon;
using UI.Shared.Component.Modals;
using UI.Shared.Component.Preload;
using UI.Shared.Component.Toasts;
using UI.Shared.Manager.Implementation;
using UI.Shared.Manager.Interface;
using UI.Shared.Models;
namespace UI.Configuration.Extension
{
    public static class ServiceConfigurationExtensions
    {
        internal static IServiceCollection AddCustomServices(this IServiceCollection services, IConfiguration _configuration)
        {
            services.AddSingleton<BootstrapClassProvider>();
            services.AddSingleton<BootstrapIconProvider>();
            services.AddScoped<ModalService>();
            services.AddScoped<ToastService>();
            services.AddScoped<PreloadService>();
            services.AddTransient<ProtectedSessionStorage>();
            services.AddScoped<IIdGenerator, IdGenerator>();
            services.AddScoped<IAuthUtilityManager, AuthUtilityManager>();
            services.AddScoped<ICacheService, CacheService>();
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
            services.AddScoped<CustomAuthenticationStateProvider>();
            services.AddManagers();

            return services;
        }

        internal static IServiceCollection AddManagers(this IServiceCollection services)
        {
            var managers = typeof(IManager);

            var types = managers
                .Assembly
                .GetExportedTypes()
                .Where(t => t.IsClass && !t.IsAbstract)
                .Select(t => new
                {
                    Service = t.GetInterface($"I{t.Name}"),
                    Implementation = t
                })
                .Where(t => t.Service != null);

            foreach (var type in types)
            {
                if (managers.IsAssignableFrom(type.Service))
                {
                    services.AddTransient(type.Service, type.Implementation);
                }
            }

            return services;
        }
    }
}
