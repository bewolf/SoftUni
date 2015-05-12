using System;

    class FibonacciNumbers
    {
        static void Main()
        {
            int a = 0;
            int b = 1;
            int temp;
            Console.Write("Enter nuber n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
                Console.Write("{0} ", temp);
            }
        }
    }