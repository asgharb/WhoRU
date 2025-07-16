namespace WhoRU.Application.Common.Localization.Helpers
{
    public static class LocalizationKeyHelper
    {
        public static bool IsValidKey(string key)
        {
            // سادهترین اعتبارسنجی: کلید نباید null یا خالی باشد
            return !string.IsNullOrWhiteSpace(key);
        }
    }
}
