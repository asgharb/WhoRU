using Microsoft.Extensions.DependencyInjection;
using WhoRU.Application.Common.Logging.Contracts;
using WhoRU.Application.Common.Logging.Services;

namespace WhoRU.Application.Common.Logging.Extensions
{
    public static class LoggingExtensions
    {
        public static IServiceCollection AddWhoRULogging(this IServiceCollection services)
        {
            services.AddSingleton<ILogEnricher, LogEnricher>();
            services.AddSingleton<FileLoggerProvider>();
            services.AddSingleton<ILoggerService, LoggerService>();

            return services;
        }
    }
}
