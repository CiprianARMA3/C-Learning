internal class Persona
{
    private string? nome;
    private string? cognome;
    
    private Persona(string? nome = null, string? cognome =null)
    {
        this.nome = nome ?? "IMP";
        this.cognome = cognome ?? "IMP";
    }
    private void Mostra()
    {
        Console.WriteLine($"{nome} / {cognome}");
    }

    public static void Main(string[] args)
    {
        Persona ciprian = new Persona("Ciprian","Mariuta");
        Persona test = new Persona();
        ciprian.Mostra();
        test.Mostra();
    }
}

internal class Program
{
   // public static void Main(string[] args)
   // {
    //    Persona ciprian = new Persona("Ciprian", "Mariuta");
    //    Persona test = new Persona();
   //     ciprian.Mostra();
   //     test.Mostra();
   //  }
}