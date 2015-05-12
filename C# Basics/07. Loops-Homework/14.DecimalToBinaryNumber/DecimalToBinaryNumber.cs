using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        long n = long.Parse(Console.ReadLine());
        string number = "";

        while (n >= 1)
        {
            number = (n % 2) + number;
            n = n / 2;
        }
        Console.WriteLine("The binary number is: {0}",number);
    }
}