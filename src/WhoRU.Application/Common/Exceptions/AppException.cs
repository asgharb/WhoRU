using System;
using System.Collections.Generic;

namespace WhoRU.Application.Common.Exceptions
{
    public abstract class AppException : Exception
    {
        public string MessageKey { get; }

        protected AppException(string messageKey)
        {
            MessageKey = messageKey;
        }

        protected AppException(string messageKey, string message) : base(message)
        {
            MessageKey = messageKey;
        }

        protected AppException(string messageKey, string message, Exception innerException) 
            : base(message, innerException)
        {
            MessageKey = messageKey;
        }
    }
}
