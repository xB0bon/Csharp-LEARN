namespace Klasy1;

internal class Car
{
    // public daje dostęp do zmiennej np. w Program.cs 
    // jednak lepiej teho nie uzywac
    
    // private ukrywa zmienną przed innymi klasami
    private string _model;
    private string _brand;
    private bool _isLuxury;
    
    // property jest słowem kluczowym, który pozwala uzyskać lub ustawić wartość zmiennej
    public string Model { get => _model;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You entered nothing!");
            }
            
            else if (value.Length < 2)
            {
                Console.WriteLine("Brand name should be at least 2 characters long!");
            }
            
            else if (value.Length > 20)
            {
                Console.WriteLine("max 20 characters!");
            }
            else
            {
                _model = value;
            } 
        }  
    }
    public string Brand {
        get
        {
            if (Luxury)
            {
                return _brand + " - Luxury Edition";
            }
            else
            {
                return _brand;
            }
        }
        
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("You entered nothing!");
            }
            
            else if (value.Length < 2)
            {
                Console.WriteLine("Brand name should be at least 2 characters long!");
            }
            
            else if (value.Length > 20)
            {
                Console.WriteLine("max 20 characters!");
            }
            else
            {
                _brand = value;
            }
            
        } 
    }
    
    public bool Luxury { get => _isLuxury; set => _isLuxury = value;}
    
    
    public Car(string brand, string model, bool luxury)
    {
        Luxury = luxury;
        Model = model;
        Brand = brand;
    }

    
    public void DisplayModel()
    {
        Console.WriteLine("A car: " + Brand + " " + Model + " has been created!");
        if (Luxury)
        {
            Console.WriteLine("it is a very luxurious car!");
        }
        else
        {
            Console.WriteLine("it is not a luxury car.");
        }
    }
}