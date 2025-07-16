using System.Threading.Tasks;

namespace WhoRU.Application.Common.Logging.Contracts
{
    public interface ILoggerService
    {
        Task LogAsync(LogEvent logEvent);
    }
}
