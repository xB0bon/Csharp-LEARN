namespace Inheritance2;

class Program
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Dog barks");
        }
    }

    public class Exercise
    {
        public void PrintSounds()
        {
            Dog dog = new Dog();
            dog.MakeSound(); // Output: Animal sound, Dog barks
        }
    }
}