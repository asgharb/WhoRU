using System.Collections.Generic;

namespace WhoRU.Application.Common.Exceptions
{
    public class ValidationException : AppException
    {
        public IDictionary<string, string[]> Errors { get; }

        public ValidationException() : base("ValidationFailed")
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(IDictionary<string, string[]> errors) : this()
        {
            Errors = errors;
        }

        public ValidationException(string messageKey) : base(messageKey)
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(string messageKey, string message) : base(messageKey, message)
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(string messageKey, string message, Exception innerException) 
            : base(messageKey, message, innerException)
        {
            Errors = new Dictionary<string, string[]>();
        }
    }
}
