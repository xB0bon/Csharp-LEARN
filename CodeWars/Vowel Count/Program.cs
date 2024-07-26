namespace Vowel_Count;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

        foreach (var i in str)
        {
            if (vowels.Contains(i))
            {
                vowelCount++;
            }
        }
        return vowelCount;
    }
}