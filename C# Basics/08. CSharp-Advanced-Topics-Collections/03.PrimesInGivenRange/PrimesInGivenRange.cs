using System;

class Primes
{
    static void Main()
    {
        Console.Write("Start number = ");
        string numberAsString = Console.ReadLine();
        int startNum = int.Parse(numberAsString);
        Console.Write("End number = ");
        numberAsString = Console.ReadLine();
        int endNum = int.Parse(numberAsString);

        FindPrimesInRange(startNum, endNum);
    }

     static void FindPrimesInRange(int startNum, int endNum)
    {
        if ((startNum > 1) && (endNum > startNum))
        {
            for (int num = startNum; num <= endNum; num++)
            {
                bool prime = true;
                int divider = 2;
                int maxDivider = (int) Math.Sqrt(num);
                while (divider <= maxDivider)
                {
                    if (num%divider == 0)
                    {
                        prime = false;
                        break;
                    }
                    divider++;
                }
                if (prime)
                {
                    Console.Write("{0} ", num);
                }
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid range!");
        }
    }
}
