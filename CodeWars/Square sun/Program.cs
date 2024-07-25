namespace Square_Sun;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"The sum of squares of the numbers is: {SquareSum(numbers)}");
    }
    
    public static int SquareSum(int[] numbers)
    {
        int result = 0;
        foreach (var number in numbers)
        {
            result += number * number;
        }
        
        return result;
    }
}