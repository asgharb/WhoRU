using System.Collections.Generic;
using System.Threading.Tasks;

namespace WhoRU.Application.Common.Localization.Providers
{
    public class CompositeLocalizationProvider : ILocalizationProvider
    {
        private readonly IList<ILocalizationProvider> _providers;

        public CompositeLocalizationProvider(IEnumerable<ILocalizationProvider> providers)
        {
            _providers = new List<ILocalizationProvider>(providers);
        }

        public async Task<string?> GetTranslationAsync(string key, string culture)
        {
            foreach (var provider in _providers)
            {
                var translation = await provider.GetTranslationAsync(key, culture);
                if (!string.IsNullOrEmpty(translation))
                {
                    return translation;
                }
            }

            return null;
        }
    }
}
