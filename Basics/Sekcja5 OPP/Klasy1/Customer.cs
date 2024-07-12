namespace Klasy1;

internal class Customer
{
    private static int _nextId = 0;
    
    private readonly int _id;

    
    
    // write only property.
    private string _password;
    public string Password
    {
        set
        {
            _password = value;
        }
    }

    public int Id
    {
        get
        {
            return _id;
        }
    }

    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    
    
    // ctor
    public Customer(string name, string address = "NA", string contactNumber = "NA")
    {
        // nextId jest statycznym (static) polimorfizmem, co oznacza że zmienna jest dla wszystkich instancji tej klasy
        _id = _nextId++;
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public void DisplayCustomerDetails()
    {

        Console.WriteLine("\nDetails about Customer: ");
        Console.WriteLine("ID: " + _id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Address: " + Address);
        Console.WriteLine("Contact Number: " + ContactNumber);
    }


}