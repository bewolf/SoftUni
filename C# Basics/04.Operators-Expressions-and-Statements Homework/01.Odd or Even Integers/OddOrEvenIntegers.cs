using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int num1 = 3;
        int num2 = 2;
        int num3 = -2;
        int num4 = -1;
        int num5 = 0;
        bool oddOrEven;
        oddOrEven = num1 % 2 == 1;
        Console.WriteLine("The number 3 is Odd: " + oddOrEven);

        oddOrEven = num2 % 2 != 0;
        Console.WriteLine("The number 2 is Odd: " + oddOrEven);

        oddOrEven = num3 % 2 != 0;
        Console.WriteLine("The number -2 is Odd: " + oddOrEven);

        oddOrEven = num4 % 2 != 0;
        Console.WriteLine("The number -1 is Odd: " + oddOrEven);

        oddOrEven = num5 % 2 != 0;
        Console.WriteLine("The number 0 is Odd: " + oddOrEven);
    }
}