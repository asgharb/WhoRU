using System;

namespace WhoRU.Application.Common.Logging.Contracts
{
    public class LogEvent
    {
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
        public string Level { get; set; } = null!;
        public string Message { get; set; } = null!;
        public Exception? Exception { get; set; }
        public string? UserId { get; set; }
        public string? IpAddress { get; set; }
        public string? AdditionalInfo { get; set; }
    }
}
