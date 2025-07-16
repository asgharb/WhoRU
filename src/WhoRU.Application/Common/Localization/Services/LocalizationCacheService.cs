using System.Collections.Concurrent;
using System.Threading.Tasks;
using WhoRU.Application.Common.Localization.Contracts;
using WhoRU.Application.Common.Localization.Providers;

namespace WhoRU.Application.Common.Localization.Services
{
    public class LocalizationCacheService : ILocalizationProvider
    {
        private readonly ILocalizationProvider _innerProvider;
        private readonly ConcurrentDictionary<string, string?> _cache = new();

        public LocalizationCacheService(ILocalizationProvider innerProvider)
        {
            _innerProvider = innerProvider;
        }

        public async Task<string?> GetTranslationAsync(string key, string culture)
        {
            string cacheKey = $"{culture}_{key}";

            if (_cache.TryGetValue(cacheKey, out var cachedValue))
            {
                return cachedValue;
            }

            var value = await _innerProvider.GetTranslationAsync(key, culture);

            _cache.TryAdd(cacheKey, value);

            return value;
        }
    }
}
