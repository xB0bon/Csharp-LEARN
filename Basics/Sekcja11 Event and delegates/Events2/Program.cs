namespace Events2;

public delegate void TemperatureChangeHandler(string message);

public class TemperatureMonitor
{
    public event TemperatureChangeHandler OnTemperatureChanged;
    private int _temperature;
    public int Temperature
    {
        get { return _temperature;}
        set
        {
            _temperature = value;
            if (_temperature > 30)
            {
                RaiseTemperatureChangedEvent($"Temperature is too high: {_temperature}");
            }
            else
            {
                RaiseTemperatureChangedEvent($"Temperature has been updated: {_temperature}");
            }
        } 
    }

    protected virtual void RaiseTemperatureChangedEvent(string message)
    {
        OnTemperatureChanged?.Invoke(message);
    }
}

public class TemperatureAlert
{
    public void OnTemperatureChanged(string message)
    {
        Console.WriteLine("Alert: " + message);
    }
}
class Program
{
    static void Main(string[] args)
    {
        TemperatureMonitor monitor = new TemperatureMonitor();
        TemperatureAlert alert = new TemperatureAlert();
        
        monitor.OnTemperatureChanged += alert.OnTemperatureChanged;

        Console.WriteLine("Please enter a temperature: ");
        int temperature = int.Parse(Console.ReadLine());
        monitor.Temperature = temperature;
    }
}