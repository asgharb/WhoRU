using System.Threading.Tasks;

namespace WhoRU.Application.Common.Localization.Contracts
{
    public interface ILocalizationService
    {
        Task<string> GetStringAsync(string key, string culture, params object[] args);
    }
}
