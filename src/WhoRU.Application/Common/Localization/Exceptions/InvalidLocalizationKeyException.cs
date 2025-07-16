using System;

namespace WhoRU.Application.Common.Localization.Exceptions
{
    public class InvalidLocalizationKeyException : Exception
    {
        public InvalidLocalizationKeyException(string key)
            : base($"Invalid localization key: {key}")
        {
        }
    }
}
