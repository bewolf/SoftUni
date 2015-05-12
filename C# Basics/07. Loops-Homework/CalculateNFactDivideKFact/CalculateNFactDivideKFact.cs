using System;

class CalculateNFactDivideKFact
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int nFact = 1;
        int kFact = 1;
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

            Console.WriteLine((nFact / kFact));
        }
        else
        {
            Console.WriteLine("Enter valid numbers! 1 < k < n < 100");
        }
    }
}