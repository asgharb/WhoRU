using System.Threading.Tasks;

namespace WhoRU.Application.Common.Localization.Providers
{
    public interface ILocalizationProvider
    {
        Task<string?> GetTranslationAsync(string key, string culture);
    }
}
