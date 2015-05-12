using System;
using System.Linq;

class SequencesOfEqualStrings
{
    static void Main()
    {
        //the program works only with sorted strings!
        string input = Console.ReadLine();
        string[] words = input.Split();
        Console.WriteLine();
        //check all strings without the last one
        for (int i = 1; i < words.Length; i++)
        {
            if (words[i-1] == words[i])
            {
                Console.Write("{0} ", words[i-1]);
            }
            else
            {
                Console.WriteLine("{0} ", words[i-1]);
            }
        }
        //check only the last string
        for (int i = words.Length-1; i < words.Length; i++)
        {
            if (words[i]==words.Last())
            {
                Console.Write("{0} ",words[i]);
            }
            else
            {
                Console.WriteLine("{0} ",words[i]);
            }
        }
        Console.WriteLine();
    }
}