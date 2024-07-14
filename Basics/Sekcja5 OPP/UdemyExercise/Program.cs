using System;

namespace UdemyExercise
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person("John", 30);
            person1.Greet();
        }
    }

    public class Person
    {
        // Auto-implemented property for Name
        public string Name { get; set; }

        // Explicit implementation for Age with validation
        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }

        // Constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Greet method
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }
    }

}