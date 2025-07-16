using System;
using System.IO;
using System.Threading.Tasks;
using WhoRU.Application.Common.Logging.Contracts;

namespace WhoRU.Application.Common.Logging.Services
{
    public class FileLoggerProvider : ILoggerService
    {
        private readonly string _logFilePath;

        public FileLoggerProvider()
        {
            _logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", "app.log");
            Directory.CreateDirectory(Path.GetDirectoryName(_logFilePath)!);
        }

        public async Task LogAsync(LogEvent logEvent)
        {
            var logLine = $"{logEvent.Timestamp:u} [{logEvent.Level}] User:{logEvent.UserId ?? "-"} IP:{logEvent.IpAddress ?? "-"} Message:{logEvent.Message}";

            if (logEvent.Exception != null)
            {
                logLine += $" Exception: {logEvent.Exception.Message}";
            }

            if (!string.IsNullOrEmpty(logEvent.AdditionalInfo))
            {
                logLine += $" AdditionalInfo: {logEvent.AdditionalInfo}";
            }

            await File.AppendAllTextAsync(_logFilePath, logLine + Environment.NewLine);
        }
    }
}
