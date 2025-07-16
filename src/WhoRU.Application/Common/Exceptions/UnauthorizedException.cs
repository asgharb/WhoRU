namespace WhoRU.Application.Common.Exceptions
{
    public class UnauthorizedException : AppException
    {
        public UnauthorizedException() : base("Unauthorized") { }
        public UnauthorizedException(string messageKey) : base(messageKey) { }
        public UnauthorizedException(string messageKey, string message) : base(messageKey, message) { }
        public UnauthorizedException(string messageKey, string message, Exception innerException) 
            : base(messageKey, message, innerException) { }
    }
}
