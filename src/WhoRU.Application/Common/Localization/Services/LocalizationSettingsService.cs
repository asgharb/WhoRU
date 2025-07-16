using System.Threading.Tasks;
using WhoRU.Application.Common.Localization.Contracts;
using WhoRU.Application.Common.Localization.DTOs;

namespace WhoRU.Application.Common.Localization.Services
{
    public class LocalizationSettingsService : ILocalizationSettingsService
    {
        private LocalizationSettingsDto _settings = new LocalizationSettingsDto
        {
            DefaultCulture = "en-US"
        };

        public Task<LocalizationSettingsDto> GetSettingsAsync()
        {
            return Task.FromResult(_settings);
        }

        public Task UpdateSettingsAsync(LocalizationSettingsDto settings)
        {
            _settings = settings;
            return Task.CompletedTask;
        }
    }
}
