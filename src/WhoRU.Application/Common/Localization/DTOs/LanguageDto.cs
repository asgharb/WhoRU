namespace WhoRU.Application.Common.Localization.DTOs
{
    public class LanguageDto
    {
        public string CultureCode { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public bool IsEnabled { get; set; }
    }
}
