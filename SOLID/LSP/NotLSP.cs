namespace Solid.SOLID.LSP;

public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Bu kuş uçuyor.");
    }
}

public class Canary : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Kanarya güzel bir şekilde uçuyor.");
    }
}

public class Penguin : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("Penguenler uçamaz!");
    }
}

