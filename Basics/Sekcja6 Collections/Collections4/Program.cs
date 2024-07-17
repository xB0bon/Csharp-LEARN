namespace Collections4;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Employe> employees = new Dictionary<int, Employe>();
        
        employees.Add(1, new Employe("John Json", 19, 2000));
        employees.Add(2, new Employe("Jane Cruise", 22, 3000));
        employees.Add(3, new Employe("Mike Holland", 25, 4000));
        employees.Add(4, new Employe("Emma Speed", 21, 3500));
        employees.Add(5, new Employe("Tom Json", 23, 2500));
        
        
        
        foreach (var employee in employees)
        {
            Console.WriteLine($"Employee ID: {employee.Key}\n" +
                              $"Employee Name: {employee.Value.Name}\n" +
                              $"Employee Age: {employee.Value.Age}\n" +
                              $"Employee Salary: {employee.Value.Salary}\n");
        }
    }
}