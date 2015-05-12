using System;

internal class FibonacciNumbers
{
    private static void Main()
    {
        Console.Write("Enter nuber n: ");
        int n = int.Parse(Console.ReadLine());

        Fib(n);
    }

    private static void Fib(int n)
    {
        int a = 0;
        int b = 1;
        int temp;
        for (int i = 0; i < n; i++)
        {
            temp = a;
            a = b;
            b = temp + b;
            Console.Write("{0} ", temp);
        }
    }
}