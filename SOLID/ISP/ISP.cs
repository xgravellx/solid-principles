namespace Solid.SOLID.ISP;

public interface IWorking
{
    void Work();
}

public interface IEating
{
    void Eat();
}

public interface IGetPaid
{
    void GetPaid();
}

public interface IJoinMeet
{
    void JoinMeet();
}

public class SoftwareDevelopers : IWorking, IEating, IGetPaid, IJoinMeet
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

public class Robots : IWorking
{
    public void Work()
    {
        Console.WriteLine("Çalış");
    }
}


