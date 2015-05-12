using System;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());

        double reversed = GetReversedNumber(number);
        Console.WriteLine(reversed);
    }

     static double GetReversedNumber(double number)
    {
        string reversedNumber = new string(number.ToString().Reverse().ToArray());
        double doubleReversedNumber = double.Parse(reversedNumber);
        return doubleReversedNumber;
    }
}