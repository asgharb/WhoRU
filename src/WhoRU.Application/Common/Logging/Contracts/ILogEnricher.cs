namespace WhoRU.Application.Common.Logging.Contracts
{
    public interface ILogEnricher
    {
        void Enrich(LogEvent logEvent);
    }
}
