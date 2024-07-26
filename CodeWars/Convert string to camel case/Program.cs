namespace Convert_string_to_camel_case;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(ToCamelCase("the-stealth-warrior"));
    }
    
    public static string ToCamelCase(string str)
    {
        char[] separators = new char[] { '-', '_' };
        str = str.ToLower();
        string[] splited = str.Split(separators);

        for (int i = 0; i < splited.Length; i++)
        {
            if (i == 0)
            {
                continue;
            }
            else
            {
                splited[i] = char.ToUpper(splited[i][0]) + splited[i].Substring(1);
            }
        }
        return string.Join("", splited);
    }
}