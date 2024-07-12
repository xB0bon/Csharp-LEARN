namespace Klasy1;

class Program
{

    
    static void Main(string[] args)
    {
        
        Customer c1 = new Customer("Paul");
        Customer c2 = new Customer("Peter");
        Customer c3 = new Customer("Mark", "123 Main St", "555-123-4567");
        Customer c4 = new Customer("Jane", "456 Elm St", "888-999-0000");
        
        
        c1.DisplayCustomerDetails();
        c2.DisplayCustomerDetails();
        c3.DisplayCustomerDetails();
        c4.DisplayCustomerDetails();


    }


    
}