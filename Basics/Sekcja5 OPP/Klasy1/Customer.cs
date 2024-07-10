namespace Klasy1;

internal class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }
    
    
    // ctor
    public Customer(string name, string address = "NA", string contactNumber = "NA")
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    
}