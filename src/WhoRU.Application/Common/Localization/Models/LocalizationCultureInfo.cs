namespace WhoRU.Application.Common.Localization.Models
{
    public class LocalizationCultureInfo
    {
        public string CultureCode { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public string NativeName { get; set; } = string.Empty;
        public bool IsNeutralCulture { get; set; }
    }
}
