namespace WhoRU.Application.Common.Exceptions
{
    public class NotFoundException : AppException
    {
        public NotFoundException() : base("NotFound") { }
        public NotFoundException(string messageKey) : base(messageKey) { }
        public NotFoundException(string messageKey, string message) : base(messageKey, message) { }
        public NotFoundException(string messageKey, string message, Exception innerException) 
            : base(messageKey, message, innerException) { }
    }
}
