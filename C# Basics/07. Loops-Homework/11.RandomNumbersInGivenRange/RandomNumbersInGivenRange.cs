using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        Random number = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ",number.Next(min, max));
        }
    }
}