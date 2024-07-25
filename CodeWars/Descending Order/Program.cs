namespace Descending_Order;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
    }
    
    public static int DescendingOrder(int num)
    {
        string numStr = num.ToString();
        char[] charArray = numStr.ToCharArray();
        Array.Sort(charArray, (a,b) => b.CompareTo(a));
        string result = new string(charArray);
        return int.Parse(result);
    }
}