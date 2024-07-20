namespace Inheritance1;

class Program
{
    static void Main(string[] args)
    {
        Dog pies = new Dog();
        Cat kot = new Cat();
        pies.MakingSound();
        kot.MakingSound();
    }
}

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

    
    // VIRTUAL umożliwia nadpisywanie tej metody w klasasach potomnych
    public virtual void MakingSound()
    {
        Console.WriteLine("Making a sound...");
    }
    
}

class Dog : Animal
{
    public override void MakingSound()
    {
        base.MakingSound();
        Console.WriteLine("Woof!");
    }
}

class Colie : Dog
{
    public void GoingNuts()
    {
        Console.WriteLine("Going for a nutty walk...");
    }
}

class Cat : Animal
{
    public override void MakingSound()
    {
        base.MakingSound();
        Console.WriteLine("Meow!");
    }
}