using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        double thirdNum = double.Parse(Console.ReadLine());

        Console.WriteLine(firstNum+secondNum+thirdNum);
    }
}
