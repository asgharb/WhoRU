namespace WhoRU.Domain.Entities.Localization;

public class Language
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Code { get; set; } = null!;        // ��� "fa-IR" �� "en-US"
    public string Name { get; set; } = null!;        // ��� ���� ��� ����� �� ������
    public bool IsDefault { get; set; } = false;     // ���� ������
}
