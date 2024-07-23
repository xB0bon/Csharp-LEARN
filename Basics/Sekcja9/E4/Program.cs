namespace E4;

class Program
{
    static void Main(string[] args)
    {
        Hammer hammer = new Hammer();
        Saw saw = new Saw();
        
        Builder builder = new Builder();
        builder.SetHammer(hammer);
        builder.SetSaw(saw);
        builder.BuildHouse();
    }
}