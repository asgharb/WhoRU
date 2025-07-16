namespace WhoRU.Domain.Entities.Localization;

public class Language
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Code { get; set; } = null!;        // „À· "fa-IR" Ì« "en-US"
    public string Name { get; set; } = null!;        // ‰«„ “»«‰ „À· ›«—”Ì Ì« «‰ê·Ì”Ì
    public bool IsDefault { get; set; } = false;     // “»«‰ ÅÌ‘›—÷
}
