namespace WhoRU.Domain.Entities.AccessControl;

public class UserPagePermission
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string UserId { get; set; } = null!;

    public Guid PageId { get; set; }

    public PermissionType Permission { get; set; }

    public Page? Page { get; set; }
}
