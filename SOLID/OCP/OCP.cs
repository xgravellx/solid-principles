namespace Solid.SOLID.OCP;

public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        // Dosya loglama işlemleri
        Console.WriteLine($"Logging to file: {message}");
    }
}

public class DatabaseLogger : ILogger
{
    public void Log(string message)
    {
        // Database loglama işlemleri
        Console.WriteLine($"Logging to database: {message}");
    }
}

public class LogManager(ILogger logger)
{
    public void Log(string message)
    {
        logger.Log(message);
    }
}