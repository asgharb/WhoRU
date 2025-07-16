namespace WhoRU.Domain.Entities.Localization;

public class LocalizedString
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Key { get; set; } = null!;           // ò·Ìœ Ìò « „À· "User.LoginFailed"
    public string LanguageCode { get; set; } = null!;  // òœ “»«‰ „À· "fa-IR"
    public string Value { get; set; } = null!;         // „ﬁœ«—  —Ã„Â

    public Language? Language { get; set; }
}
