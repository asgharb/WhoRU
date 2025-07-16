namespace WhoRU.Application.Common.Localization.DTOs
{
    public class LocalizationSettingsDto
    {
        public string DefaultCulture { get; set; } = string.Empty;
        public List<LanguageDto> SupportedLanguages { get; set; } = new List<LanguageDto>();
    }
}
