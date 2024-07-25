namespace Isograms;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine(IsIsogram("aaa"));
    }
    
    public static bool IsIsogram(string str)
    {
        List<string> letters = new List<string>();
        str = str.ToLower().Trim();
        // Code on you crazy diamond!
        foreach (var i in str)
        {
            if (letters.Exists(word => word == i.ToString()))
            {
                return false;
            }
            else
            {
                letters.Add(i.ToString());
            }
        }
        return true;
    }
    
    
}