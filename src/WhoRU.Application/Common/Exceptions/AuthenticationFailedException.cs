namespace WhoRU.Application.Common.Exceptions
{
    public class AuthenticationFailedException : AppException
    {
        public AuthenticationFailedException() : base("AuthenticationFailed") { }
        public AuthenticationFailedException(string messageKey) : base(messageKey) { }
        public AuthenticationFailedException(string messageKey, string message) : base(messageKey, message) { }
        public AuthenticationFailedException(string messageKey, string message, Exception innerException) 
            : base(messageKey, message, innerException) { }
    }
}
