namespace WhoRU.Application.Common.Localization.Models
{
    public class Language
    {
        public string CultureCode { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public bool IsEnabled { get; set; } = true;
    }
}
