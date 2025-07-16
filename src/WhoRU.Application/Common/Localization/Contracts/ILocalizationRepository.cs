using System.Collections.Generic;
using System.Threading.Tasks;
using WhoRU.Application.Common.Localization.Models;

namespace WhoRU.Application.Common.Localization.Contracts
{
    public interface ILocalizationRepository
    {
        Task<LocalizationEntry?> GetLocalizationEntryAsync(string key, string culture);

        Task<IReadOnlyList<LocalizationEntry>> GetLocalizationEntriesAsync(string culture);

        Task<IReadOnlyList<Language>> GetLanguagesAsync();

        Task AddOrUpdateLocalizationEntryAsync(LocalizationEntry entry);
    }
}
