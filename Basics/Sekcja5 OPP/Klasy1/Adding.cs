namespace Klasy1;

internal class Adding
{
    public double FistNumber { get; set; }
    public double SecondNumber { get; set; }

    
    
    // readonly constructor
    public double Output
    {
        get
        {
            return FistNumber + SecondNumber;
        }
    }
}