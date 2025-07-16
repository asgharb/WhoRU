using WhoRU.Domain.Enums;

namespace WhoRU.Domain.Entities.Identity;

public class UserLoginLog
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string UserId { get; set; } = null!;
    public DateTime AttemptedAt { get; set; } = DateTime.UtcNow;
    public string IPAddress { get; set; } = null!;
    public string UserAgent { get; set; } = null!;
    public LoginStatus Status { get; set; }

    public ApplicationUser? User { get; set; }
}
