namespace QUIZ;

class Program
{
    static void Main(string[] args)
    {

        Question[] questions = new Question[]
        {
            new Question("What is the capital of Norway?", 
                new string[] {"Oslo", "Berlin", "Paris", "Copenhagen"},
                0),

            new Question("What is the capital of Sweden?", 
                new string[] {"London", "Stockholm", "Madrid", "Vienna"},
                1),

            new Question("What is the capital of England?", 
                new string[] {"Madrid", "Tallin", "Dublin", "London"},
                3),

            new Question("What is the capital of Austria?", 
                new string[] {"Vienna", "Berlin", "Paris", "Rome"},
                0),

            new Question("What is the capital of Italy?", 
                new string[] {"Milan", "Venice", "Rome", "Madrid"},
                2),

            new Question("What is the capital of Denmark?", 
                new string[] {"Copenhagen", "Paris", "Berlin", "London"},
                0),

            new Question("What is the capital of France?", 
                new string[] {"Berlin", "Marseille", "Madrid", "Paris"},
                3),

            new Question("What is the capital of Poland?", 
                new string[] {"Warsaw", "Kiev", "Moscow", "Paris"},
                0),

            new Question("What is the capital of Germany?", 
                new string[] {"Berlin", "Paris", "London", "Warsaw"},
                0),

            new Question("What is the capital of Spain?", 
                new string[] {"Madrid", "Barcelona", "Valencia", "Berlin"},
                0),



            
            // Add more questions here...
        };
        
        Quiz quiz = new Quiz(questions);
        quiz.StartQuiz();

        Console.ReadKey();
    }
}