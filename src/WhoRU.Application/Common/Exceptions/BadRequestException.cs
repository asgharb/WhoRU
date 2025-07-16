namespace WhoRU.Application.Common.Exceptions
{
    public class BadRequestException : AppException
    {
        public BadRequestException() : base("BadRequest") { }
        public BadRequestException(string messageKey) : base(messageKey) { }
        public BadRequestException(string messageKey, string message) : base(messageKey, message) { }
        public BadRequestException(string messageKey, string message, Exception innerException) 
            : base(messageKey, message, innerException) { }
    }
}
