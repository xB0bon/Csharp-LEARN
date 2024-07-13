namespace QUIZ;

internal class Question
{
    public string QuestionText { get; set; }
    
    public string[] Answers { get; set; }
    
    public int CorrectAnswerIndex { get; set; }

    public Question(string questionText, string[] answers, int correctAnswerIndex)
    {
        QuestionText = questionText;
        Answers = answers;
        CorrectAnswerIndex = correctAnswerIndex;
    }

    public bool isCorrectAnswer(int choice)
    {
        // Display the correct answer and indicate whether the user's choice was correct or not.'
        if (CorrectAnswerIndex == choice)
            Console.WriteLine("Correct!");
        else
            Console.WriteLine($"Wrong! The correct answer was: {Answers[CorrectAnswerIndex]}");
        
        Thread.Sleep(500);
        // Compare the user's choice with the correct answer index and return true if they match, false otherwise.'
        return CorrectAnswerIndex == choice;
    }
}