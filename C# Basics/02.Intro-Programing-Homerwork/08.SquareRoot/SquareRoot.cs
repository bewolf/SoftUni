using System;

public class SquareRoot
{
    public static void Main()
    {
        Console.WriteLine("Enter a Number : ");
        int Number = Convert.ToInt32(Console.ReadLine());
        double SqrtNumber = Math.Sqrt(Number);
        Console.WriteLine("Square root of {0} is: {1}", Number, SqrtNumber);
    }
}