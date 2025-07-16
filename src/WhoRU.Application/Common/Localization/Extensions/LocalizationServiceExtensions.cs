using Microsoft.Extensions.DependencyInjection;
using WhoRU.Application.Common.Localization.Contracts;
using WhoRU.Application.Common.Localization.Providers;
using WhoRU.Application.Common.Localization.Services;

namespace WhoRU.Application.Common.Localization.Extensions
{
    public static class LocalizationServiceExtensions
    {
        public static IServiceCollection AddLocalizationServices(this IServiceCollection services)
        {
            // ثبت Provider ها
            services.AddScoped<ILocalizationProvider, DatabaseLocalizationProvider>();
            services.AddScoped<ILocalizationProvider, ResourceFileLocalizationProvider>();
            services.AddScoped<ILocalizationProvider>(sp =>
            {
                var providers = new ILocalizationProvider[]
                {
                    sp.GetRequiredService<DatabaseLocalizationProvider>(),
                    sp.GetRequiredService<ResourceFileLocalizationProvider>()
                };
                return new CompositeLocalizationProvider(providers);
            });

            // ثبت Service ها
            services.AddScoped<ILocalizationService, LocalizationService>();

            return services;
        }
    }
}
