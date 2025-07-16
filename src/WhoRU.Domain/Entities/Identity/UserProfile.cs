using WhoRU.Domain.Enums;

namespace WhoRU.Domain.Entities.Identity;

public class UserProfile
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string UserId { get; set; } = null!;
    public string? AvatarUrl { get; set; }
    public string? NationalCode { get; set; }
    public string? Address { get; set; }
    public string? Bio { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime? BirthDate { get; set; }
    public Gender? Gender { get; set; }
    public ApplicationUser? User { get; set; }
}
