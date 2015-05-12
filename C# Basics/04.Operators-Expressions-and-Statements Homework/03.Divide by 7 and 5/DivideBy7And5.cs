using System;

class DivideBy7And5
{
    static void Main()
    {
        bool divide;
        Console.Write("Enter number: ");
        int theNumber = int.Parse(Console.ReadLine());
        if (theNumber % 5 == 0 && theNumber % 7 == 0 && theNumber != 0)
        {
            divide = true;
            Console.WriteLine(divide);
        }
        else
        {
            divide = false;
            Console.WriteLine(divide);
        }
    }
}
