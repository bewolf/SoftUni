using System;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number between 1 and 20");
        int n = int.Parse(Console.ReadLine());
        int rows;
        for (rows = 1; rows <= n; rows++)
        {
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", i + rows);
            }
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
