using System;
using System.Numerics;
class Calculate7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger nMinusKFact = 1;
        if (1 < k && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
                if (i <= k)
                {
                    kFact *= i;
                }
            }
            for (int j = 1; j <= n - k; j++)
            {
                nMinusKFact *= j;
            }
            Console.WriteLine(nFact/ (kFact*nMinusKFact));
        }
        else
        {
            Console.WriteLine("Enter valid numbers! 1 < k < n < 100");
        }
    }
}