
// inheritance in c#
public class Vehicle {

    public string? Brand { get; set; }
    public int? Year { get; set; }
    public Vehicle(string? Brand = null, int? Year = null)
    {
        this.Brand = Brand ?? "Brand not given";
        this.Year = Year;
    }
    public void showInfo()
    {
        string converted_year = Year.HasValue ? Year.Value.ToString() : "Not given";
        Console.WriteLine($"Brand : {Brand} && Year : {converted_year}");
    }
}

public class Car : Vehicle {
    public int? Doors { get; set; }
    public Car(string? brand= null , int? year=null, int? Doors= null) : base(brand,year){
        this.Doors = Doors;
    }
    public void showInfo()  
    {
        string converted_year = Year.HasValue ? Year.Value.ToString() : "Not given";
        Console.WriteLine($"Brand : {Brand} && Year : {converted_year} && doors : {Doors}");
    }
}


class Program
{
    public static void Main(string[] args)
    {
        Car macchina = new Car("BMW",2000,4);
        macchina.showInfo();
        
    }
}

