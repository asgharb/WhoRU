namespace WhoRU.Domain.Entities.AccessControl;

public enum PermissionType
{
    Create = 1,
    Read = 2,
    Update = 3,
    Delete = 4,
    // œ— ’Ê—  ‰Ì«“ „Ì Ê«‰ „Ê«—œ œÌê— «÷«›Â ò—œ „À· Export, Print, Approve Ê €Ì—Â
}

public class PagePermission
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid PageId { get; set; }
    public PermissionType Permission { get; set; }

    public Page? Page { get; set; }
}
