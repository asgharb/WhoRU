namespace WhoRU.Domain.Entities.AccessControl;

public class Page
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = null!;           // ���� "Products"
    public string DisplayName { get; set; } = null!;    // ���� "������ �������"
    public string? Description { get; set; }            // ����� ����
    public string ControllerName { get; set; } = null!; // ��� ������ �� Page Name
    public string? ActionName { get; set; }             // ������� null ���� �� ��� ǘ�� ���

    public ICollection<PagePermission> Permissions { get; set; } = new List<PagePermission>();
    public ICollection<RolePagePermission> RolePermissions { get; set; } = new List<RolePagePermission>();
    public ICollection<UserPagePermission> UserPermissions { get; set; } = new List<UserPagePermission>();
}
