namespace Inheritance3;

class Program
{
    static void Main(string[] args)
    {
        Employee student = new Employee("John", 15, "Junior Programist");
        Employee student2 = new Employee("Mike", 55, "Senior Programist");
        Menager menager1 = new Menager("Micheal", 50, "Menager", 15);
        student.Greet(); 
        student2.Greet(); // Output: Hello, my name is Mike and I am 55 years old.
        menager1.DisplayMenagerInfo();
    }
}

public class Person
{

    public string Name { get; private set; }
    public int Age { get; private set; }
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    
    public virtual void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

public class Employee : Person
{
    private static int _nextId = 0;

    public int ID
    {
        get;
        private set;
    }

    public string JobTitle { get; set; }

    public Employee(string name, int age, string jobTitle) : base(name, age)
    {
        JobTitle = jobTitle;
        ID = ++_nextId;  // Increment the static ID counter for each new student object.  This ID is unique for each student object.  The static ID counter is not shared across different instances of the Student class.  It is a class-level variable.  The ID is not tied to any particular student object.  It is shared among all student objects created using the Student class.  The ID is generated based on the number of student objects created.  The ID is not
        
    }

    public override void Greet()
    {
        base.Greet();
        Console.WriteLine($"I am a Employee with ID {ID} and my job title is {JobTitle}.");
    }
}

public class Menager : Employee
{
    public int TeamSize { get; private set; }
    public Menager(string name, int age, string jobTitle, int teamSize) : base(name, age, jobTitle)
    {
        TeamSize = teamSize;
    }

    public void DisplayMenagerInfo()
    {
        Greet();
        Console.WriteLine($"I am a Manager with a team size of {TeamSize}.");
    }
}