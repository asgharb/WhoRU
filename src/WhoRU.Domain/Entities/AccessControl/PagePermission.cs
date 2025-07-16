namespace WhoRU.Domain.Entities.AccessControl;

public enum PermissionType
{
    Create = 1,
    Read = 2,
    Update = 3,
    Delete = 4,
    // �� ���� ���� ������ ����� ��� ����� ��� ��� Export, Print, Approve � ����
}

public class PagePermission
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid PageId { get; set; }
    public PermissionType Permission { get; set; }

    public Page? Page { get; set; }
}
