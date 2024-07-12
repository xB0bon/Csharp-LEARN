namespace QUIZ;

internal class Question
{
    public string QuestionText { get; set; }
    
    public string[] PossibleAnswers { get; set; }
    
    public int CorrectAnswerIndex { get; set; }
}