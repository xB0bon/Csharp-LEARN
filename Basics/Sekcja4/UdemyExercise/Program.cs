namespace UdemyExercise;

class Program
{
    static void Main(string[] args)
    {
        double[] temperatures = { 45.5, 32.0, 1.0, 4.0, 6.0, 8.0, 3.0, 11.0, -7.0 };
        
        PrintAverage(temperatures);
    }
    
    static void PrintAverage(double[] temperatures)
    {
        double average = CalculateAverage(temperatures);

        Console.WriteLine("The average temperature is: " + average);
    }

    static double CalculateAverage(double[] temperatures)
    {
        double sum = 0;
        foreach (double temperature in temperatures)
        {
            sum += temperature;
        }
        
        return (sum / temperatures.Length);
    }
}