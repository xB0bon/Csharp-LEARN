int firstNumber;
int secondNumber;
string userInput;
string operation;

Console.WriteLine("Enter the first number:");
userInput = Console.ReadLine();

if (!int.TryParse(userInput, out firstNumber))
{
    Console.WriteLine("Invalid number!!!");
    return;
}

Console.WriteLine("Enter the second number:");
userInput = Console.ReadLine();

if (!int.TryParse(userInput, out secondNumber))
{
    Console.WriteLine("Invalid number!!!");
    return;
}

Console.WriteLine("Enter an operator (+, -, *, /):");
operation = Console.ReadLine();

switch (operation)
{
    case "+":
        Console.WriteLine($"Result: {firstNumber + secondNumber}");
        break;
    case "-":
        Console.WriteLine($"Result: {firstNumber - secondNumber}");
        break;
    case "*":
        Console.WriteLine($"Result: {firstNumber * secondNumber}");
        break;
    case "/":
        if (firstNumber == 0 || secondNumber == 0)
            Console.WriteLine("Error: Division by zero is not allowed.");
        else
            Console.WriteLine($"Result: {(double)firstNumber / (double)secondNumber}");
        break;
    default:
        Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
        break;
        
}