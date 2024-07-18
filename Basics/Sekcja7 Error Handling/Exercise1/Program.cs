namespace Exercise1;

class Program
{
    static void Main(string[] args)
    {
        int result = 0;
        int num1 = 5;
        int num2 = 0;

        try
        {
            result = num1 / num2;
            Console.WriteLine(result);
        }
        
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        finally
        {
            Console.WriteLine("Result: " + result);
        }
        
        
    }
}