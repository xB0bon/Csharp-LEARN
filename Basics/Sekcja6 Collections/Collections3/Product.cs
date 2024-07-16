namespace Collections3;

public class Product
{
    public string Name { get; set; }
    
    // decimal jest lepsze do cen
    public decimal Price { get; set; }
    
    
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}