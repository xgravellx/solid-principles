namespace Solid.SOLID.ISP;

public interface IWorker
{
    void Work();
    void Eat();
    void GetPaid();
    void JoinMeet();
}

public class SoftwareDeveloper : IWorker
{
    public void Work()
    {
        Console.WriteLine("Çalış");
    }
    
    public void Eat()
    {
        Console.WriteLine("Yemek ye");
    }
    
    public void GetPaid()
    {
        Console.WriteLine("Maaş al");
    }
    
    public void JoinMeet()
    {
        Console.WriteLine("Toplantıya katıl");
    }
}

public class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Çalış");
    }
    
    public void Eat()
    {
        // Robot yemek yemez, bu metod burada anlamsız.
        throw new NotImplementedException();;
    }
    
    public void GetPaid()
    {
        // Robot maaş almaz, bu metod burada anlamsız.
        throw new NotImplementedException();
    }
    
    public void JoinMeet()
    {
        // Robot toplantılara katılmaz, bu metod burada anlamsız.
        throw new NotImplementedException();
    }
}

