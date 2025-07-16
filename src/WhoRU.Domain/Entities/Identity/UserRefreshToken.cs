namespace WhoRU.Domain.Entities.Identity;

public class UserRefreshToken
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string UserId { get; set; } = null!;
    public string RefreshToken { get; set; } = null!;
    public string Device { get; set; } = null!;
    public string IPAddress { get; set; } = null!;
    public DateTime ExpiryDate { get; set; }
    public bool IsRevoked { get; set; } = false;

    public ApplicationUser? User { get; set; }
}
