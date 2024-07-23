namespace E4;

public class Builder : IToolUser
{
    private Hammer _hammer;
    private Saw _saw;
    
    public Builder()
    {
        _hammer = new Hammer();
        _saw = new Saw();
    }

    

    public void SetHammer(Hammer hammer)
    {
        _hammer = hammer;
    }

    public void SetSaw(Saw saw)
    {
        _saw = saw;
    }
    
    public void BuildHouse()
    {
        _hammer.Use();
        _saw.Use();
        Console.WriteLine("Hause is built");
    }
}