using System.Text.RegularExpressions;

namespace Regex1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string pattern = @"\d";
        Regex regex = new Regex(pattern);

        string text = "My number is 123";
        
        MatchCollection matchCollection = regex.Matches(text);
        
        
        foreach (Match match in matchCollection)
        {
            GroupCollection group = match.Groups;
            Console.WriteLine($"Found1: {group[0].Value}");
            Console.WriteLine($"Found2: {match.Value}");
        }

        Console.WriteLine(matchCollection.Count + " hits found in: '" + text + "'");
    }
}