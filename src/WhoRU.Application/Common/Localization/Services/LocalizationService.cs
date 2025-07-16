using System.Threading.Tasks;
using WhoRU.Application.Common.Localization.Contracts;
using WhoRU.Application.Common.Localization.Providers;

namespace WhoRU.Application.Common.Localization.Services
{
    public class LocalizationService : ILocalizationService
    {
        private readonly ILocalizationProvider _provider;

        public LocalizationService(ILocalizationProvider provider)
        {
            _provider = provider;
        }

        public async Task<string> GetStringAsync(string key, string culture, params object[] args)
        {
            var translation = await _provider.GetTranslationAsync(key, culture);
            if (string.IsNullOrEmpty(translation))
                return key;

            if (args == null || args.Length == 0)
                return translation;

            return string.Format(translation, args);
        }
    }
}
