namespace Method2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What mathematical action do you want to perform?");
        Console.WriteLine("Enter (+, -, *, /) : ");

        char[] actions = { '+', '-', '/', '*' };
        
    
        bool contains = false;

        char operation;
        do
        {
            Console.Clear();
            Console.WriteLine("What mathematical action do you want to perform?");
            Console.WriteLine("Enter (+, -, *, /) : ");
            
            
            operation = Console.ReadLine()[0];
            contains = actions.Contains(operation);
            
        } while (!contains);
        

        Console.WriteLine("Enter first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        double result = 0;
        switch (operation)
        {
            case '+':
                result = Adding(number1, number2);
                break;
            case '-':
                result = Subtracting(number1, number2);
                break;
            case '*':
                result = Multiplying(number1, number2);
                break;
            case '/':
                result = Dividing(number1, number2);
                break;
            default:
                Console.WriteLine("Invalid input! Please enter a valid mathematical operation (+, -, *, /).");
                break;
            
            
            
        }

        Console.WriteLine("Result: " + result);
        
        

        

    }
    
    static double Adding(int number1, int number2)
    {
        return (number1 + number2);
    }
        
    static double Subtracting(int number1, int number2)
    {
        return (number1 - number2);
    }
        
    static double Multiplying(int number1, int number2)
    {
        return (number1 * number2);
    }

    static double Dividing(int number1, int number2)
    {
        if (number1 != 0 && number2 != 0)
        {
            return (double)number1 / number2;
        }
        else
        {
            Console.WriteLine("You can't divide by zero!");
            return double.NaN;
        }
            
    }
    
}