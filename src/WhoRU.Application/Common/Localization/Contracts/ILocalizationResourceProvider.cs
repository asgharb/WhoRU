namespace WhoRU.Application.Common.Localization.Contracts
{
    public interface ILocalizationResourceProvider
    {
        string? GetResource(string key, string culture);
    }
}
