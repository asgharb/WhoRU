using Microsoft.AspNetCore.Identity;

namespace WhoRU.Domain.Entities.Identity;

public class ApplicationUser : IdentityUser
{
    public UserProfile? Profile { get; set; }

    public ICollection<UserRefreshToken> RefreshTokens { get; set; } = new List<UserRefreshToken>();

    public ICollection<UserLoginLog> LoginLogs { get; set; } = new List<UserLoginLog>();
}
