class User
{
    public string? name { get; set; }
    public User(string? name = null)
    {
        this.name = name;
    }
}
class PhoneNumber : User
{
    public int? numero_telefonico { get; set; }
    public PhoneNumber(int? numero_telefonico, string? name) : base(name)
    {
        this.numero_telefonico = numero_telefonico;
    }
    public void output()
    {
        Console.WriteLine($"Name : {name} && Phone number : {numero_telefonico}");
    }
}


class Program
{
    public static void Main()
    {
        PhoneNumber ciprian = new PhoneNumber(000, "ciprian");
        ciprian.output();
        Test1 test = new Test1("ciao");
        Console.WriteLine(Test1.input);
        Test1.output();

    }
}

class Test1
{
    public static string? input { get; set; }
    public Test1(string? inputComp = null)
    {
        input = inputComp;
    }
    public static void output()
    {
        Console.WriteLine("output123");
    }
}