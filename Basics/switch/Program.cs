Console.WriteLine("Jaki jest miesiąc (numer)?:  ");
int month = Convert.ToInt32(Console.ReadLine());

switch (month)
{
    case 1:
        Console.WriteLine("Styczeń");
        break;
    case 2:
        Console.WriteLine("Luty");
        break;
    case 3:
        Console.WriteLine("Marzec");
        break;
    case 4:
        Console.WriteLine("Kwiecień");
        break;
    case 5:
        Console.WriteLine("Maj");
        break;
    case 6:
        Console.WriteLine("Czerwiec");
        break;
    case 7:
        Console.WriteLine("Lipiec");
        break;
    case 8:
        Console.WriteLine("Sierpień");
        break;
    case 9:
        Console.WriteLine("Wrzesień");
        break;
    case 10:
        Console.WriteLine("Październik");
        break;
    case 11:
        Console.WriteLine("Listopad");
        break;
    case 12:
        Console.WriteLine("Grudzień");
        break;
    default:
        Console.WriteLine("Nieprawidłowy numer miesiąca!");
        break;
}