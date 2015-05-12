using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        string d = Convert.ToString(a, 2).PadLeft(10, '0');

        Console.WriteLine("|{0,-10:X} |{1}|{2,10:F2}|{3,-10:F3}|", a, d, b, c);
    }
}