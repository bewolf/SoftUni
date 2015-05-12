using System;

class RandomizeTheNumbers1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Random number = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", number.Next(1, n));
        }
    }
}