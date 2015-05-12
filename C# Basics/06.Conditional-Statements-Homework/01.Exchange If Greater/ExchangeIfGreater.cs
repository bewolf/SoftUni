using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter number a: " );
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: " );
        double b = double.Parse(Console.ReadLine());
        if (a > b)
	{
        Console.WriteLine("{0} {1}", b, a); 
	}
        else
        {
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
