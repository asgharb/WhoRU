namespace WhoRU.Application.Common.Exceptions
{
    public class ConflictException : AppException
    {
        public ConflictException() : base("Conflict") { }
        public ConflictException(string messageKey) : base(messageKey) { }
        public ConflictException(string messageKey, string message) : base(messageKey, message) { }
        public ConflictException(string messageKey, string message, Exception innerException) 
            : base(messageKey, message, innerException) { }
    }
}
