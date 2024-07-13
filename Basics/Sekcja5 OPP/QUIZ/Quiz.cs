namespace QUIZ;

internal class Quiz
{

    private int _choice;
    private int _score = 0;
    private int _scoreInPercentages;
    private Question[] _questions;

    public Quiz(Question[] questions)
    {
        _questions = questions;
    }

    public void StartQuiz()
    {
        foreach (var question in _questions)
        {
            DisplayQuestionAndAnswer(question);
        }
        DisplayResult();
    }
    
    private void DisplayQuestionAndAnswer(Question questions)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔═══════════════════════════════════╗");
        Console.WriteLine("║             Question              ║");
        Console.WriteLine("╚═══════════════════════════════════╝");
        // Question
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(questions.QuestionText);
        
        // Answers
        Console.ResetColor();

        for (int i = 0; i < questions.Answers.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"  {i + 1}.");
            Console.ResetColor();
            Console.WriteLine($" {questions.Answers[i]}");
            
        }
        // Get you user answer
        _choice = GetUserChoice();
        
        
        // Check if the answer is correct and update the score
        if (questions.isCorrectAnswer(_choice - 1))
        {
            _score++;
        }
        
    }

    private int GetUserChoice()
    {
        
        string userInput = "";
        bool isNumber;
            
        do
        {
            Console.WriteLine("\nYour choice (1 - 4):");
            userInput = Console.ReadLine();
            isNumber = int.TryParse(userInput, out _choice);
        } while (!isNumber);

        return _choice;
    }

    private void DisplayResult()
    {
        // Display the result after the quiz
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("╔═══════════════════════════════════╗");
        Console.WriteLine("║               Result              ║");
        Console.WriteLine("╚═══════════════════════════════════╝");
        
        Console.ResetColor();
        
        Console.WriteLine("Number of questions: " + _questions.Length);
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Your score: " + _score);
        if (_score != 0 && _questions.Length != 0 )
        {
            _scoreInPercentages = (_score * 100) / _questions.Length;
        }

        else
            _scoreInPercentages = 0;
        
        Console.WriteLine("Your score in percent: " + _scoreInPercentages + "%");
        Console.WriteLine();
    }
    
}