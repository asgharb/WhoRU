
using Microsoft.AspNetCore.Identity;

namespace WhoRU.Domain.Entities.Identity;

public class ApplicationRole : IdentityRole
{
    public ICollection<ApplicationRoleClaim> Claims { get; set; } = new List<ApplicationRoleClaim>();
}
