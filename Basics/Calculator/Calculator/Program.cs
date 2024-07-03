// See https://aka.ms/new-console-template for more information


// tworzenie zmiennych

using System.Globalization;

double firstNumber;
double secondNumber;

// pierwsza liczba
Console.WriteLine("Enter first number: ");
// Replace - zamienia dany znak i inny wybrany
string input = Console.ReadLine().Replace(".", ",");
firstNumber = Convert.ToDouble(input);

// zamiast replace można zastosować CultureInfo.InvariantCulture
//np.
// firstNumber = double.Parse(input, CultureInfo.InvariantCulture);


// drugi znak
Console.WriteLine("Enter second number: ");
input = Console.ReadLine().Replace(".", ",");
secondNumber = double.Parse(input);

// obliczanie
double sum = firstNumber + secondNumber;
sum = Math.Round(sum, 3);

// wyświetlanie wyniku
Console.WriteLine($"{firstNumber.ToString(CultureInfo.InvariantCulture)} + {secondNumber.ToString(CultureInfo.InvariantCulture)} = {sum.ToString(CultureInfo.InvariantCulture)}");
