namespace WhoRU.Application.Common.Exceptions
{
    public class DuplicateEntityException : AppException
    {
        public DuplicateEntityException() : base("DuplicateEntity") { }
        public DuplicateEntityException(string messageKey) : base(messageKey) { }
        public DuplicateEntityException(string messageKey, string message) : base(messageKey, message) { }
        public DuplicateEntityException(string messageKey, string message, Exception innerException) 
            : base(messageKey, message, innerException) { }
    }
}
