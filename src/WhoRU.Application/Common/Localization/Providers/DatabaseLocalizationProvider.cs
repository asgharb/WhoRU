
using WhoRU.Application.Common.Localization.Contracts;

namespace WhoRU.Application.Common.Localization.Providers
{
    public class DatabaseLocalizationProvider : ILocalizationProvider
    {
        private readonly ILocalizationRepository _repository;

        public DatabaseLocalizationProvider(ILocalizationRepository repository)
        {
            _repository = repository;
        }

        public async Task<string?> GetTranslationAsync(string key, string culture)
        {
            var entry = await _repository.GetLocalizationEntryAsync(key, culture);
            return entry?.Value;
        }
    }
}
