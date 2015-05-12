using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.Write("Enter second number:");
        double secondNum = double.Parse(Console.ReadLine());

        Console.WriteLine("Greater is: {0}",firstNum>secondNum? firstNum : secondNum);
    }
}