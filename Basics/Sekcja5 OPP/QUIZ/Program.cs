namespace QUIZ;

class Program
{
    static void Main(string[] args)
    {

        Question[] questions = new Question[]
        {
            new Question("What is the capisal of Germany?", 
                new string[] {"Paris", "Berlin", "London", "Warsaw"},
                1),
            
            new Question("What is the capisal of Poland?", 
                new string[] {"Kiev", "Warsaw", "Moscow", "Paris"},
                1),
            
            new Question("What is the capisal of England?", 
                new string[] {"Madrit", "Tallin", "London", "Dublin"},
                2),
            
            new Question("What is the capisal of France?", 
                new string[] {"Paris", "Marseille", "London", "Madrid"},
                0),
            
            new Question("What is the capital of Spain?", 
                new string[] {"Madrid", "Barcelona", "Valencia", "London"},
                0),
            
            new Question("What is the capital of Italy?", 
                new string[] {"Rome", "Venice", "London", "Milan"},
                0),
            
            new Question("What is the capital of Sweden?", 
                new string[] {"Stockholm", "London", "Paris", "Copenhagen"},
                0),
            
            new Question("What is the capital of Austria?", 
                new string[] {"Vienna", "Berlin", "Paris", "Madrid"},
                0),
            
            new Question("What is the capital of Norway?", 
                new string[] {"Oslo", "Berlin", "Paris", "Copenhagen"},
                0),

            
            // Add more questions here...
        };
        
        Quiz quiz = new Quiz(questions);
        foreach (var question in questions)
        {
            quiz.DisplayQuestionAndAnswer(question);
        }
        quiz.DisplayResult();

        Console.ReadKey();
    }
}