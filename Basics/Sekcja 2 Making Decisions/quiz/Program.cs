// Define questions and answers for the quiz
string q1 = "What is the capital of Poland? : ";
string a1 = "Warsaw";

string q2 = "What is the capital of Germany? : ";
string a2 = "Berlin";

string q3 = "What is the capital of France? : ";
string a3 = "Paris";

// Initialize score counter
int score = 0;

// Ask question 1 and check answer
Console.WriteLine(q1);
string userAnswer = Console.ReadLine();

if (userAnswer.Trim() == a1.ToLower())
    Console.WriteLine($"Correct answer! Score = {++score}");

else
{
    Console.WriteLine("Wrong answer! Correct answer is {0}. Score = {1}", a1, score);
}

// Ask question 2 and check answer
Console.WriteLine(q2);
userAnswer = Console.ReadLine();

if (userAnswer.Trim().ToLower() == a2.ToLower())
    Console.WriteLine($"Correct answer! Score = {++score}");

else
{
    Console.WriteLine("Wrong answer! Correct answer is {0}. Score = {1}", a2, score);
}

// Ask question 3 and check answer
Console.WriteLine(q3);
userAnswer = Console.ReadLine();

if (userAnswer.Trim().ToLower() == a3.ToLower())
    Console.WriteLine($"Correct answer! Score = {++score}");

else
{
    Console.WriteLine("Wrong answer! Correct answer is {0}. Score = {1}", a3, score);
}

// Display final score
Console.WriteLine($"Your final score is {score}/3");