namespace Solid.SOLID.OCP;

public class NotOcp(string logType)
{
    public void Log(string message)
    {
        if (logType == "file")
        {
            // Dosyaya loglama işlemleri
            Console.WriteLine("Logging to file: " + message);
        }
        else if (logType == "database")
        {
            // Veritabanına loglama işlemleri
            Console.WriteLine("Logging to database: " + message);
        }
        // Her yeni loglama türü için, buraya yeni bir koşul eklememiz gerekir.
        // Bu, OCP'ye aykırıdır çünkü yeni loglama türleri eklemek için mevcut kodu değiştirmemiz gerekmektedir.
    }
}
