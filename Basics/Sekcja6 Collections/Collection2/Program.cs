namespace Collection2;

class Program
{
    static void Main(string[] args)
    {
        List<string> colors = new List<string>() {"Red", "Green", "Yellow", "Blue", "Purple", "Aquamarine", "Orange"};
        List<int> numbers = new List<int>() {4,6,2,22,7,2,1,8,4,3,2,11, 15, 16, 101};
        
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


        Predicate<int> isGreaterThanTen = x => x > 10;
        Console.WriteLine("\nNumbers greater than 10");
        
        //foreach (var number in numbers.FindAll(x => x > 10))
        // lub
        foreach (var number in numbers.FindAll(isGreaterThanTen))
        {
            Console.Write(number+",");
        }

        bool numberisGreaterThanHundred = numbers.Any(number => number > 100);

        if (numberisGreaterThanHundred)
        {
            Console.WriteLine("\nthere is a number greater than 100 in this list: ");
            foreach (var number in numbers.FindAll(number => number > 100))
            {
                Console.Write(number+",");
            }
        }
        
        else 
            Console.WriteLine("\nthere are no numbers greater than 100 in this list");

        
    }
}