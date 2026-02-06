// interface

interface IAnimali
{
    void suono();
    void test();
}
internal class Cane : IAnimali
{
    public void suono()
    {
        Console.WriteLine("bau bau");
    }
    public void test() {
        Console.WriteLine("test");
    }
}
internal class Program
{
    public static void Main(string[]args)
    {
        Cane aky = new Cane();
        aky.suono();
    }
}