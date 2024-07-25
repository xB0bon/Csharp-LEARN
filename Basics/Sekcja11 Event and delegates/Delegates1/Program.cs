namespace Delegates1;

class Program
{

    private delegate void Notify(string message);
    
    static void Main(string[] args)
    {
        Notify notifyDelegate = ShowMessage;
        notifyDelegate("Hello Delegates!");
    }

    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
}