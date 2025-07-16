namespace WhoRU.Domain.Entities.AccessControl;

public class RolePagePermission
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string RoleId { get; set; } = null!;

    public Guid PageId { get; set; }

    public PermissionType Permission { get; set; }

    public Page? Page { get; set; }
}
