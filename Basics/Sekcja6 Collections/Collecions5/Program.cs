namespace Collecions5;

class Program
{
    
    static void Main(string[] args)
    {
        Dictionary<int, Student> students = new Dictionary<int, Student>();
        
        students.Add(1, new Student("John", 85));
        students.Add(2, new Student("Alice", 90));
        students.Add(3, new Student("Bob", 78));
        
        // Loop through the dictionary and print student names and grades
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Value.Name}," +
                              $" Id: {student.Key}," +
                              $" Grade: {student.Value.Grade}");
        }
        
        



    }
}