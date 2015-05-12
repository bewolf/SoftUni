using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int theNumber = int.Parse(Console.ReadLine());
        Console.WriteLine((theNumber / 100) % 10 == 7 ?  true : false);
    }
}

