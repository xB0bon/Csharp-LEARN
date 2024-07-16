namespace Collections3;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>() {new Product("Eggs", 12m),
            new Product("bananas", 5.5m),
            new Product("Milk", 3.4m),
            new Product("Apples", 7m),
            new Product("Oranges", 4m),
            new Product("Cheese", 10m),
            new Product("Bread", 2m),
            new Product("Fish", 15m),
            new Product("Cereal", 8m),
            new Product("Chicken", 18m)
        };

        foreach (var product in products)
        {
            Console.WriteLine($"Product name: {product.Name}, Product price: {product.Price} zł");
        }

        
        
        List<Product> expensiveProducts = products.Where(x => x.Price > 10).ToList();
        
        Console.WriteLine("Expensive products: ");
        //foreach (var product in products.Where(x => x.Price> 10))
        foreach (var product in expensiveProducts)
        {
            Console.WriteLine($"Product name: {product.Name}, Product price: {product.Price} zł");
        }
    }
}