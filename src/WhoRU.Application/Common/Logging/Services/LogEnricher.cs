using WhoRU.Application.Common.Logging.Contracts;

namespace WhoRU.Application.Common.Logging.Services
{
    public class LogEnricher : ILogEnricher
    {
        public void Enrich(LogEvent logEvent)
        {
            // میتوانید اینجا اطلاعات دلخواه مثل UserId  IP  ThreadId و غیره را اضافه کنید
            // برای مثال:
            // logEvent.UserId = GetCurrentUserId();
            // logEvent.IpAddress = GetUserIpAddress();
        }
    }
}
