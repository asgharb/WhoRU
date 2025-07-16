namespace WhoRU.Domain.Entities.Notifications;

public interface INotificationService
{
    Task SendAsync(Notification notification);
}
