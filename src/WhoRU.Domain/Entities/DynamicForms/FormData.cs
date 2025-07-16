namespace WhoRU.Domain.Entities.DynamicForms;

public class FormData
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid FormId { get; set; }
    public string UserId { get; set; } = null!; // ���� ����� �� ���� ����� ���

    public string DataJson { get; set; } = null!; // ������ �� ���� JSON ����� �����

    public DateTime SubmittedAt { get; set; } = DateTime.UtcNow;

    public Form? Form { get; set; }
}
