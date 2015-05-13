using System;
using System.Collections.Generic;
using System.IO.Ports;

class CountSymbols
{
    private static void Main()
    {
        string input = Console.ReadLine();
        SortedDictionary<char, int> letters = new SortedDictionary<char, int>();

        foreach (char symbol  in input)
        {
            if (letters.ContainsKey(symbol))
            {
                letters[symbol]++;
            }
            else
            {
                letters.Add(symbol,1);
            }
        }

        foreach (KeyValuePair<char, int> pair in letters)
        {
            Console.WriteLine("{0} -> {1} time/s",pair.Key,pair.Value);
        }
    }
}