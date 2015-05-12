using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double result = new double();
        int nfact = 1;
        decimal xN = 1;
        for (int i = 1; i <= n; i++)
        {
            nfact *= i;
            xN *= x;
            result += (double)(nfact / xN);

        }
        Console.WriteLine("{0:0.00000}", result+1);
    }
}
