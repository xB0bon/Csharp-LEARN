namespace Structs1;


struct Point
{

    public double X { get; }
    public double Y { get; }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }

    public double DistanceTo(Point other)
    {
        double dx = other.X - X ;
        double dy = other.Y - Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(10,20);
        p1.Display();

        Point p2 = new Point(20,30);
        p2.Display();
        
        Point p3 = p1;
        p3.Display();
        
        Console.WriteLine($"Distance between p1 and p2: {Math.Round(p1.DistanceTo(p2), 2)}");
    }
}