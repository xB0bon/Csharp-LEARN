namespace Methods3___Weather_Simulator;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        
        Console.WriteLine("Enter number of days to simulate: ");
        int days = Convert.ToInt32(Console.ReadLine());
        
        string[] conditions = { "sunny", "cloudy", "rainy", "snowy", "clear and sunny", "cloudy with scattered sunlight", "showers and rain", "light snowfall" };
        int[] temperature = new int[days];
        string[] weather = new string[days];
        int randomNumber;
        double avrageTemperature;
        
        for (int i = 0; i < days; i++)
        {
            randomNumber = random.Next(0, conditions.Length);
            temperature[i] = random.Next(-10, 40);
            weather[i] = conditions[randomNumber];

            Console.WriteLine($"Day {i + 1}: \nTemperature: {temperature[i]} \nweather: {weather[i]}\n\n");
        }

        int sum = 0;
        foreach (int i in temperature)
        {
            sum += i;
        }

        avrageTemperature = (double)sum / days;

        Console.WriteLine("Average Temperature: " + Math.Round(avrageTemperature, 2));

    }
}