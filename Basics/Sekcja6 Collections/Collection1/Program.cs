namespace Collection1;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> {1, 2, 3};

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
