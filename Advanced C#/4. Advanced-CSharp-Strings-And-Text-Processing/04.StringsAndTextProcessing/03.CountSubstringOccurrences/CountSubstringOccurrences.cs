using System;
using System.Text.RegularExpressions;

class CountSubstringOccurrences
    {
        static void Main()
        {
            string inputString = Console.ReadLine();
            string inputSubString = Console.ReadLine();

            Console.WriteLine(NumberOccurrences(inputString,inputSubString));
        }

        private static int NumberOccurrences(string inputString, string inputSubString)
        {
            int count = 0;
            for (int i = 0; i < inputString.Length - inputSubString.Length+1; i++)
            {
                if (inputSubString == inputString.Substring(i, inputSubString.Length))
                {
                    count++;
                }
            }
            return count;
        }
    }