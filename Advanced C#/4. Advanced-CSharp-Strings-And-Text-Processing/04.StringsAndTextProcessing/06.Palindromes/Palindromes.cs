using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Palindromes
{
    static void Main()
    {
        string inputText = Console.ReadLine();

        SearchForPalindromes(inputText);
    }

    private static void SearchForPalindromes(string inputText)
    {
        inputText = Regex.Replace(inputText, @">?[.?!,]", "");
        string[] inputArr = inputText.Split().ToArray();
        List<string> palindromes = new List<string>();
        for (int i = 0; i < inputArr.Length; i++)
        {
            if (inputArr[i].SequenceEqual(inputArr[i].Reverse()))
            {
                palindromes.Add(inputArr[i]);
                palindromes.Sort();
            }
        }
        foreach (var palindrome in palindromes)
        {
            Console.Write("{0} ", palindrome);
        }

    }
}