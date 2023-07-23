namespace Domain.Settings;

public class NotificationSettings
{
    public int Id { get; set; } 

    public string UserId { get; set; }

    public bool PushNotification { get; set; }

    public bool EmailNotification { get; set; }

    public string? EmailAddress { get; set; }
}