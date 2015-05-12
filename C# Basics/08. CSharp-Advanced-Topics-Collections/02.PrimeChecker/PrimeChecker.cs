using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a positive integer number: ");
        uint number = uint.Parse(Console.ReadLine());
        IsPrime(number);
    }

    private static void IsPrime(uint number)
    {
        uint divider = 2;
        uint maxDivider = (uint) Math.Sqrt(number);
        bool prime = true;
        while (prime && (divider <= maxDivider))
        {
            if (number%divider == 0)
            {
                prime = false;
            }
            divider++;
        }
        Console.WriteLine("Prime? {0}", prime);
    }
}
