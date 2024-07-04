
bool isTrue = true;
int userNumber = 0;
int attemptNumber = 0;


Random random = new Random();
int randomNumber = random.Next(1,101);

while (isTrue)
{
  
    Console.WriteLine("write a number from 1 to 100: ");
    // int userNumber = Convert.ToInt32(Console.ReadLine());
    bool isNumber = int.TryParse(Console.ReadLine(), out userNumber);
    if (isNumber)
    {
        if (userNumber == randomNumber)
        {
            Console.WriteLine("Congratulations, you've guessed the correct number! ({0} attempts)", ++attemptNumber);
            
            bool wantToEnd = false;

            while (!wantToEnd)
            {
                Console.WriteLine("\nDo you want to play again? (y/n) : ");
                string wannaPlayAgain = Console.ReadLine();
                
                if (wannaPlayAgain.ToLower().Trim() == "y" || wannaPlayAgain.ToLower().Trim() == "yes")
                {
                    wantToEnd = true;
                    Console.WriteLine("\n\n\n\n\n\n");
                }
                else if (wannaPlayAgain.ToLower().Trim() == "n" || wannaPlayAgain.ToLower().Trim() == "no")
                {
                    wantToEnd = true;
                    isTrue = false;
                }
                else
                {
                    continue;
                }
            }
            
            
            
            randomNumber = random.Next(1,100);
        }
        else if (userNumber > randomNumber)
        {
            attemptNumber++;
            Console.WriteLine("Too high, try again!");
        }

        else if (userNumber < randomNumber)
        {
            attemptNumber++;
            Console.WriteLine("Too low, try again!");
        }
    }
    else
    {
        attemptNumber++;
        Console.WriteLine("Invalid number!");
    }
    
    

    
}
    
