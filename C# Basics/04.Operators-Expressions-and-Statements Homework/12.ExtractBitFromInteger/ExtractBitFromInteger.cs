using System;

    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter position : ");
            int p = int.Parse(Console.ReadLine());
            int numRightN = n >> p;
            int bit = numRightN & 1;
            Console.WriteLine(bit);
        }
    }
