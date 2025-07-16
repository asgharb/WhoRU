namespace WhoRU.Domain.Entities.Localization;

public class LocalizedString
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Key { get; set; } = null!;           // ���� ��� ��� "User.LoginFailed"
    public string LanguageCode { get; set; } = null!;  // �� ���� ��� "fa-IR"
    public string Value { get; set; } = null!;         // ����� �����

    public Language? Language { get; set; }
}
