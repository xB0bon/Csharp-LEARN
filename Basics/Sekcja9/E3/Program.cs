namespace E3;

interface ILogger
{
    void Log(string message);
}

class FileLogger : ILogger
{
    public void Log(string message)
    {
        File.AppendAllText("logs.txt", message + "\n");
    }
}

class Aplication
{
    private readonly ILogger _logger;

    public Aplication(ILogger logger)
    {
        _logger = logger;
    }
    
    public void DoWork(string message)
    {
        _logger.Log(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        File.AppendAllText("logs.txt", "Hello, world!" + "\n");
        Console.WriteLine("Hello, World!");
    }
}