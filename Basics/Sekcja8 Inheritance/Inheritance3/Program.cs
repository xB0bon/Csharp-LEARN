namespace Inheritance3;

public class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
        Console.WriteLine($"Person constructor: {Name}");
    }
}

public class Employee : Person
{
    public int ID { get; set; }

    public Employee(string name, int id) : base(name)
    {
        ID = id;
        Console.WriteLine($"Employee constructor: {name}, ID: {ID}");
    }


    public class Exercise
    {
        public void PrintMessages()
        {
            Employee e1 = new Employee("John Doe", 123);
        }
    }
}