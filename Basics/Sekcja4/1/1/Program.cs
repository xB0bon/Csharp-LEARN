// See https://aka.ms/new-console-template for more information


// Method Declaration
int AddTwoValues(int number1, int number2)
{
    int result = number1 + number2;
    return result;
}


Console.WriteLine("Please Enter first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please Enter second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


// Calling the method "Add"
int myResult = AddTwoValues(firstNumber, secondNumber);

Console.WriteLine("Result is: " + myResult);

