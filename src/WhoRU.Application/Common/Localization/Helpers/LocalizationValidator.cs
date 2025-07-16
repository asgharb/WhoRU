namespace WhoRU.Application.Common.Localization.Helpers
{
    public static class LocalizationValidator
    {
        public static bool ValidateEntry(string key, string value)
        {
            // اعتبارسنجی ساده: کلید و مقدار نباید خالی باشند
            return !string.IsNullOrWhiteSpace(key) && !string.IsNullOrWhiteSpace(value);
        }
    }
}
