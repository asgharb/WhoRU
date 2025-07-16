using WhoRU.Domain.Enums;

namespace WhoRU.Domain.Entities.Notifications;

public class Notification
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string UserId { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Message { get; set; } = null!;
    public bool IsRead { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public NotificationType Type { get; set; }
}
