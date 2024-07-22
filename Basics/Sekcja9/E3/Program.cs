namespace E3;

class Program
{
    static void Main(string[] args)
    {
        File.AppendAllText("log.txt", "Hello, world!" + "\n");
        Console.WriteLine("Hello, World!");
    }
}