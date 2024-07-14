namespace Collection2;

class Program
{
    static void Main(string[] args)
    {
        List<string> colors = new List<string>() {"Red", "Green", "Yellow", "Blue", "Purple", "Aquamarine", "Orange"};
        List<int> numbers = new List<int>() {4,6,2,22,7,2,1,8,4,3,2,11};
        
        Console.WriteLine("Original List: ");
        foreach (var number in numbers)
        {
            Console.Write(number + ",");
        }
        numbers.Sort();
        Console.WriteLine("\nSorted List: ");
        foreach (var number in numbers)
        {
            Console.Write(number + ",");
        }
    }
}