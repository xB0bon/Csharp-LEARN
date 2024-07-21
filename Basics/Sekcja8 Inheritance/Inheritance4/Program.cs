namespace Inheritance4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Dog dog = new Dog();
        Cat cat = new Cat();
        dog.MakeSound();
        cat.MakeSound();
    }
}

public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}