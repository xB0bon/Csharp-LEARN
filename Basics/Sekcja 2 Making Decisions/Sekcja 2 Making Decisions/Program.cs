// See https://aka.ms/new-console-template for more information

bool isRainy = true;
bool hasUmbrella = true;

if (isRainy && !hasUmbrella)
{   
    Console.WriteLine("It's raining, but you don't have an umbrella. You'll have to take an umbrella.");
}

else if (isRainy && hasUmbrella)
{
    Console.WriteLine("It's raining and you have an umbrella. You can enjoy the weather.");
}

else if (!isRainy)
{
    Console.WriteLine("It's not raining, so you can enjoy the weather without an umbrella.");
}
