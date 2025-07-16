using System.Threading.Tasks;
using WhoRU.Application.Common.Localization.DTOs;

namespace WhoRU.Application.Common.Localization.Contracts
{
    public interface ILocalizationSettingsService
    {
        Task<LocalizationSettingsDto> GetSettingsAsync();

        Task UpdateSettingsAsync(LocalizationSettingsDto settings);
    }
}
