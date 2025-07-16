using System.Globalization;
using System.Resources;
using System.Threading.Tasks;

namespace WhoRU.Application.Common.Localization.Providers
{
    public class ResourceFileLocalizationProvider : ILocalizationProvider
    {
        private readonly ResourceManager _resourceManager;

        public ResourceFileLocalizationProvider(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        public Task<string?> GetTranslationAsync(string key, string culture)
        {
            var cultureInfo = new CultureInfo(culture);
            var value = _resourceManager.GetString(key, cultureInfo);
            return Task.FromResult(value);
        }
    }
}
