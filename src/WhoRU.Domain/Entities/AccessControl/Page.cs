namespace WhoRU.Domain.Entities.AccessControl;

public class Page
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Name { get; set; } = null!;           // „À·« "Products"
    public string DisplayName { get; set; } = null!;    // „À·« "„œÌ—Ì  „Õ’Ê·« "
    public string? Description { get; set; }            //  Ê÷ÌÕ ’›ÕÂ
    public string ControllerName { get; set; } = null!; // ‰«„ ò‰ —·— Ì« Page Name
    public string? ActionName { get; set; }             // „Ì Ê«‰œ null »«‘œ Ì« ‰«„ «ò‘‰ Œ«’

    public ICollection<PagePermission> Permissions { get; set; } = new List<PagePermission>();
    public ICollection<RolePagePermission> RolePermissions { get; set; } = new List<RolePagePermission>();
    public ICollection<UserPagePermission> UserPermissions { get; set; } = new List<UserPagePermission>();
}
