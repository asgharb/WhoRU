namespace WhoRU.Application.Common.Exceptions
{
    public class ResourceLockedException : AppException
    {
        public ResourceLockedException() : base("ResourceLocked") { }
        public ResourceLockedException(string messageKey) : base(messageKey) { }
        public ResourceLockedException(string messageKey, string message) : base(messageKey, message) { }
        public ResourceLockedException(string messageKey, string message, Exception innerException) 
            : base(messageKey, message, innerException) { }
    }
}
