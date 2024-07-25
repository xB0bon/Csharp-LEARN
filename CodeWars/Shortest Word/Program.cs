namespace Shortest_Word;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
    }
    public static int FindShortestWordLength(string sentence)
    {
        string[] words = sentence.Split();
        int shortestLength = words[0].Length;
        foreach (var word in words)
        {
            if (word.Length < shortestLength)
            {
                shortestLength = word.Length;
            }
        }
        return shortestLength;
    }
}

