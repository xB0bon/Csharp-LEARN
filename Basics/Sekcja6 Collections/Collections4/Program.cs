namespace Collections4;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> employees = new Dictionary<int, string>();
        
        employees.Add(1, "John Doe");
        employees.Add(2, "Jane Smith");
        employees.Add(3, "Michael Johnson");
        employees.Add(4, "Emily Davis");
        
        foreach (var employee in employees)
        {
            Console.WriteLine($"Employee ID: {employee.Key}, Employee Name: {employee.Value}");
        }
    }
}