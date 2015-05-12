using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter positive number: ");
        int n = int.Parse(Console.ReadLine());
        if (n < 0 || n == 0 || n == 1)
        {
            Console.WriteLine(false);
        }
        else
        {
            for (int a = 2; a <= n / 2; a++)
            {
                if (n % a == 0)
                {
                    Console.WriteLine(false);
                }
            }
            Console.WriteLine(true);
        }
    }
    
}