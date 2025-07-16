namespace WhoRU.Application.Common.Localization.Helpers
{
    public static class CultureHelper
    {
        public static bool IsSupportedCulture(string cultureCode, IEnumerable<string> supportedCultures)
        {
            return supportedCultures.Contains(cultureCode);
        }
    }
}
