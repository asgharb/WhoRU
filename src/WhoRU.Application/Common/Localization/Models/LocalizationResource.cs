namespace WhoRU.Application.Common.Localization.Models
{
    public class LocalizationResource
    {
        public string Key { get; set; } = string.Empty;
        public Dictionary<string, string> Translations { get; set; } = new Dictionary<string, string>();
    }
}
