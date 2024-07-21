namespace E1;

class Program
{
    static void Main(string[] args)
    {
        Dog pies = new Dog();
        pies.MakeSound();
        pies.Eat("bones");
        
        Cat kot = new Cat();
        kot.MakeSound();
        kot.Eat("fish");
    }
}


// instrukcje które mówią klasą jakie voidy muszą mieć.
public interface IAnimal
{
    void MakeSound();
    void Eat(string food);
}

public class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
    
    public void Eat(string food)
    {
        Console.WriteLine($"Dog eats {food}");
    }
}


public class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
    
    public void Eat(string food)
    {
        Console.WriteLine($"Cat eats {food}");
    }
}