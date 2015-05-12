using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double catalanMember = new double();
        BigInteger nFact = 1;
        BigInteger doubleNFact = 1;
        BigInteger nPlusOneFact = 1;
        for (int i = 1; i <= n; i++)
        {    
            nFact *= i;            
        }
        for (int j = 1; j <= n + 1; j++)
        {
            nPlusOneFact *= j;
        }
        for (int k = 1; k <= n*2; k++)
        {
            doubleNFact *= k;
        }
        catalanMember = (double)(doubleNFact / (nPlusOneFact * nFact));
        Console.WriteLine(catalanMember);
    }
}