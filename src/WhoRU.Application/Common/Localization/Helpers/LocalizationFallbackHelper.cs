namespace WhoRU.Application.Common.Localization.Helpers
{
    public static class LocalizationFallbackHelper
    {
        public static string GetFallbackCulture(string culture)
        {
            // مثلا اگر فرهنگ fa-IR باشد fallback به fa یا en-US برگردانده شود
            if (culture.StartsWith("fa")) return "fa";
            return "en-US";
        }
    }
}
