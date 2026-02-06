using System.Security.Cryptography.X509Certificates;

public enum Semaforo
{
    VERDE,
    GIALLO,
    ROSSO
}

public class ControllaPermessi
{
    public  void Check(Semaforo luce)
    {
        switch (luce)
        {
            case Semaforo.ROSSO:
                Console.WriteLine("Non puoi passare");
                break;
            case Semaforo.GIALLO:
                Console.WriteLine("rallentare");
                break;
            case Semaforo.VERDE:
                Console.WriteLine("vai");
                break;
        }

    }
}


public enum Ruoli
{
    Manager,
    Developer,
    Tester
}
public enum Permessi
{
    Read,Write,Delete
}

public class ControlloRuoli
{
    public static string[] AssegnaRuoli(Ruoli ruolo)
    {
        string[] permissions = [];

        switch (ruolo)
        {
            case Ruoli.Manager:
                permissions = new string[] {
                    nameof(Permessi.Read),
                    nameof(Permessi.Write),
                    nameof(Permessi.Delete)
                };
                break;
            case Ruoli.Developer:
                permissions = new string[]
                {
                    nameof(Permessi.Write),
                    nameof(Permessi.Read)
                };break;
            case Ruoli.Tester:
                permissions = new string[]
                {
                    nameof(Permessi.Read)
                };
                break;
        }
        return permissions;
    }


    class Program
    {
        public static void Main(string[] args)
        {
            ControllaPermessi auto = new ControllaPermessi();
            auto.Check(Semaforo.GIALLO);

            string[] permessiOttenuti = ControlloRuoli.AssegnaRuoli(Ruoli.Manager);
            foreach (string s in permessiOttenuti)
            {
                Console.WriteLine(s);
            }
        }
    }
}