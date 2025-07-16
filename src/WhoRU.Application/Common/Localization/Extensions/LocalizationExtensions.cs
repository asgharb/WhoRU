using WhoRU.Application.Common.Localization.Contracts;

namespace WhoRU.Application.Common.Localization.Extensions
{
    public static class LocalizationExtensions
    {
        public static string Localize(this ILocalizationService service, string key, string culture, params object[] args)
        {
            return service.GetString(key, culture, args);
        }
    }
}
