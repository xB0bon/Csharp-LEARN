namespace Klasy1;

class Program
{

    
    static void Main(string[] args)
    {
        Car car = new Car("Audi", "A6", true);
        Console.WriteLine("Enter brand: ");
        car.Brand = Console.ReadLine();
        
        Console.WriteLine("Enter model: ");
        car.Model = Console.ReadLine();

        //Console.WriteLine("Is it a luxury car? (true/false)");
        car.DisplayModel();
        
    }
    
}