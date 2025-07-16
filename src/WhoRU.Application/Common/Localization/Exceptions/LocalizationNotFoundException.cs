using System;

namespace WhoRU.Application.Common.Localization.Exceptions
{
    public class LocalizationNotFoundException : Exception
    {
        public LocalizationNotFoundException(string key, string culture)
            : base($"Localization key '{key}' not found for culture '{culture}'.")
        {
        }
    }
}
