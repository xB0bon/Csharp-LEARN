namespace Klasy1;

class Program
{

    
    static void Main(string[] args)
    {
        Customer peter = new Customer("Peter");
        Customer FrankTheTank = new Customer("FrankTheTank", "FrankTheTank@gmail.com", "552345234");
        Console.WriteLine($"Customer name : {peter.Name}");
        Console.WriteLine($"Customer name : {FrankTheTank.Name}");
        
        
        
    }
    
}