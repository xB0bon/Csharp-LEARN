using System.Diagnostics.CodeAnalysis;

namespace DataTime;

class Program
{
    static void Main(string[] args)
    {
        
        DateTime dataTime = new DateTime(2008, 11, 30);
        Console.WriteLine();
        Console.WriteLine("my birthday is " + dataTime);
        Console.WriteLine("Current date and time: " + DateTime.Now);
        Console.WriteLine("Tomorrow: " + GetTomorrow());
        Console.WriteLine(DateTime.Today.DayOfWeek);
        Console.WriteLine(DateTime.Today.DayOfYear);

        Console.WriteLine($"Current time: {DateTime.Now.Hour} : {DateTime.Now.Minute} : {DateTime.Now.Second}");

        DateTime now = DateTime.Now;
        
        Console.WriteLine("Write a date in this format: yyyy-mm-dd: ");
        string input = Console.ReadLine();
        if (DateTime.TryParse(input, out dataTime))
        {
            Console.WriteLine(dataTime);
            TimeSpan daysPassed = now.Subtract(dataTime);
            
            Console.WriteLine($"Days passed since {dataTime.ToShortDateString()}: {daysPassed.Days}");
        }
        else
            Console.WriteLine("Invalid date format. Please use yyyy-mm-dd.");
    }

    static DateTime GetTomorrow()
    {
        return DateTime.Today.AddDays(1);
    }
}
