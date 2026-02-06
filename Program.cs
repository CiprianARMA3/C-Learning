// polymorphism
// public virtual && override
// oppure public abstract && override.


public abstract class Animali
{
    public abstract void suono();
    public void dorme()
    {
        Console.WriteLine("zzzz...");
    }
}
public class Cane : Animali
{
    public override void suono()
    {
        Console.WriteLine("Bau bau");
    }
}
public class Gatto : Animali
{
    public override void suono()
    {
        Console.WriteLine("Miao miao");
    }
}

internal class Program
{
    public static void Main(string[] args)
    {
        Gatto gatto = new Gatto();
        gatto.suono();
        gatto.dorme();
    }
}