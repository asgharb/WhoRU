namespace WhoRU.Application.Common.Exceptions
{
    public class ForbiddenException : AppException
    {
        public ForbiddenException() : base("Forbidden") { }
        public ForbiddenException(string messageKey) : base(messageKey) { }
        public ForbiddenException(string messageKey, string message) : base(messageKey, message) { }
        public ForbiddenException(string messageKey, string message, Exception innerException) 
            : base(messageKey, message, innerException) { }
    }
}
