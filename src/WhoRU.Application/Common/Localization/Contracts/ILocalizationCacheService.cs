namespace WhoRU.Application.Common.Localization.Contracts
{
    public interface ILocalizationCacheService
    {
        void CacheResource(string key, string culture, string value);
        string? GetCachedResource(string key, string culture);
    }
}
