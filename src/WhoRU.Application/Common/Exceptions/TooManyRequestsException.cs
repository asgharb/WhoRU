namespace WhoRU.Application.Common.Exceptions
{
    public class TooManyRequestsException : AppException
    {
        public TooManyRequestsException() : base("TooManyRequests") { }
        public TooManyRequestsException(string messageKey) : base(messageKey) { }
        public TooManyRequestsException(string messageKey, string message) : base(messageKey, message) { }
        public TooManyRequestsException(string messageKey, string message, Exception innerException) 
            : base(messageKey, message, innerException) { }
    }
}
