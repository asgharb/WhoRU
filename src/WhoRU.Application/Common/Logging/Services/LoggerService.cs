using System.Threading.Tasks;
using WhoRU.Application.Common.Logging.Contracts;

namespace WhoRU.Application.Common.Logging.Services
{
    public class LoggerService : ILoggerService
    {
        private readonly ILogEnricher _logEnricher;
        private readonly FileLoggerProvider _fileLogger;

        public LoggerService(ILogEnricher logEnricher, FileLoggerProvider fileLogger)
        {
            _logEnricher = logEnricher;
            _fileLogger = fileLogger;
        }

        public async Task LogAsync(LogEvent logEvent)
        {
            _logEnricher.Enrich(logEvent);
            await _fileLogger.LogAsync(logEvent);
            // در آینده میتوانید لاگ را به سرویسهای دیگر هم بفرستید
        }
    }
}
