namespace Solid.SOLID.DIP;

public class EmailService
{
    public static void SendEmail(string message)
    {
        // Email gönderme işlemleri
        Console.WriteLine("Email gönderildi: " + message);
    }
}

public class User
{
    private EmailService _emailService = new();
    
    public void Notify(string message)
    {
        EmailService.SendEmail(message);
    }
}
