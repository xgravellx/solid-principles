public interface INotificationService
{
    void Send(string message);
}

public class EmailService : INotificationService
{
    public void Send(string message)
    {
        // Email gönderme işlemleri
        Console.WriteLine("Email ile bildirim: " + message);
    }
}

public class SmsService : INotificationService
{
    public void Send(string message)
    {
        // SMS gönderme işlemleri
        Console.WriteLine("SMS ile bildirim: " + message);
    }
}

public class User(INotificationService notificationService)
{
    public void Notify(string message)
    {
        notificationService.Send(message);
    }
}
