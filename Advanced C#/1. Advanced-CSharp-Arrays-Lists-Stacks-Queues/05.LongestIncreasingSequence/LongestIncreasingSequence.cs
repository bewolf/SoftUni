using System;
using System.Linq;

class LongestIncreasingSequence
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] numbs = input.Split().Select(int.Parse).ToArray();
        Console.WriteLine();
        int counter = 1;
        int maxLenght = 1;
        int end = 0;

        Console.Write("{0} ", numbs[0]);
        for (int i = 1; i < numbs.Length; i++)
        {
            if (numbs[i] > numbs[i - 1])
            {
                Console.Write("{0} ", numbs[i]);
                counter++;
            }
            else
            {
                counter = 1;
                Console.WriteLine();
                Console.Write("{0} ", numbs[i]);

            }
            if (counter > maxLenght)
            {
                maxLenght = counter;
                end = i;
            }
        }
        Console.WriteLine();
        Console.Write("Longest: ");
        for (int j = end - maxLenght + 1; j <= end; j++)
        {
            Console.Write("{0} ", numbs[j]);
        }
    }
}