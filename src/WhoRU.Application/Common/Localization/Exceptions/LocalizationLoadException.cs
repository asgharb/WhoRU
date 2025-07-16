using System;

namespace WhoRU.Application.Common.Localization.Exceptions
{
    public class LocalizationLoadException : Exception
    {
        public LocalizationLoadException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
