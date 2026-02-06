internal class Persona
{
    private string? nome;
    public string NomeFetched { get { return nome ?? "NULL"; } set { nome = value; } } //return to nome ; set nome = value;
    private string? testoprivato;
    public string testo { get { return testoprivato ?? "NULL"; } set { testoprivato = value; } } 
    
}

internal class Program
{
    public static void Main(string[] args)
    {
        Persona ciprian = new Persona();
        ciprian.NomeFetched = "Ciprian";
        Console.WriteLine(ciprian.NomeFetched);
        ciprian.testo = "ciao";
        Console.WriteLine(ciprian.testo);
    }
}