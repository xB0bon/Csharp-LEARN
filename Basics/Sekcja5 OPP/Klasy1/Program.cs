namespace Klasy1;

class Program
{

    
    static void Main(string[] args)
    {
        Adding dodawanie = new Adding();
        
        dodawanie.FistNumber = 5;
        dodawanie.SecondNumber = 3;
        
        Console.WriteLine($"Wynik dodawania: {dodawanie.Output}");

    }


    
}