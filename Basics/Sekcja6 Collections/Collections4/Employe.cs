namespace Collections4;

public class Employe
{
    public string Name { get; set; }

    public int Age { get; set; }

    public int Salary { get; set; }

    public Employe(string name, int age, int salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
}