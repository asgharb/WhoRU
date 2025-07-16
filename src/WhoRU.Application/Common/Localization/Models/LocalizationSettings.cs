namespace WhoRU.Application.Common.Localization.Models
{
    public class LocalizationSettings
    {
        public string DefaultCulture { get; set; } = "en-US";
        public List<Language> SupportedLanguages { get; set; } = new List<Language>();
    }
}
