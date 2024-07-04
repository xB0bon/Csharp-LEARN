
bool isTrue = true;


Random random = new Random();
int randomNumber = random.Next(1,100);

while (isTrue)
{
    try
    {
        
        Console.WriteLine("write a number from 1 to 100: ");

        int userNumber = Convert.ToInt32(Console.ReadLine());

        if (userNumber == randomNumber)
        {
            Console.WriteLine("Congratulations, you've guessed the correct number!");
            randomNumber = random.Next(1,100);
        }
        else if (userNumber > randomNumber)
        {
            Console.WriteLine("Too high, try again!");
        }

        else if (userNumber < randomNumber)
        {
            Console.WriteLine("Too low, try again!");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e);
    }
    
}
    
