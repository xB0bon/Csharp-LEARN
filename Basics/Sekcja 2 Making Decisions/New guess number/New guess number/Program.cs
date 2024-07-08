// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;

Random random = new Random();

int secretNumber = random.Next(1, 101);
int attempt = 0;


Console.WriteLine("Hello, guess the number from 1 - 100! : ");
bool game = true;

while (game)
{
    string userInput = Console.ReadLine();
    int userNumber;
    bool correctNumber = int.TryParse(userInput, out userNumber);

    while (!correctNumber)
    {
        Console.WriteLine("Enter ONLY number : ");
        userInput = Console.ReadLine();
        correctNumber = int.TryParse(userInput, out userNumber);
    }

    if (userNumber > secretNumber)
    {
        attempt++;
        Console.WriteLine("Too high, try again!");
    }
    else if (userNumber < secretNumber)
    {
        attempt++;
        Console.WriteLine("Too low, try again!");
    }
    else
    {
        attempt++;
        Console.WriteLine("Congratulation! You won in {0} attempts!", attempt);
        game = false;
    }
        
    
}
