namespace Solid.SOLID;

public abstract class Bird
{
    
}

public interface ICanFly
{
    void Fly();
}

public class Canary : Bird, ICanFly
{
    public void Fly()
    {
        Console.WriteLine("Kanarya uçar");
    }
}

public class Penguin : Bird
{
    // Penguen sınıfı IUçabilir arayüzünü implemente etmez,
    // çünkü penguenler uçamaz 
}