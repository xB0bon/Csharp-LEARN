namespace Collection2;

public class exercise
{
    public exercise()
    {
        List<int> exerciseList = new List<int>() {1,2,3,4,5,6,7,8,9};

        bool numbersGreaterThanFive = exerciseList.Any(number => number > 5);
        

        Console.WriteLine(numbersGreaterThanFive);
    }
}