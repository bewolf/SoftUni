using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class LongestAreaInArray
{
    static void Main()
    {
        uint n;
        string lastString = "", longestSeqString = "";
        uint longestSequence = 1, currentSequence = 0;

        Console.WriteLine("How many strings are you going to enter?");
        n = uint.Parse(Console.ReadLine());
        string[] strings = new string[n];
        //Array.Sort(strings);  //if you want to see how much is the longest elements
        for (uint i = 0; i < n; i++)
        {
            Console.WriteLine("Enter {0} more element of the array:", n - i);
            strings[i] = Console.ReadLine();
            if (lastString == strings[i])
            {
                currentSequence++;
                if (currentSequence > longestSequence)
                {
                    longestSequence = currentSequence;
                    longestSeqString = strings[i];
                }
            }
            else
            {
                currentSequence = 1;
            }
            lastString = strings[i];
        }

        Console.WriteLine(longestSequence);

        for (int i = 1; i <= longestSequence; i++)
        {
            Console.WriteLine(longestSeqString);
        }
    }
}