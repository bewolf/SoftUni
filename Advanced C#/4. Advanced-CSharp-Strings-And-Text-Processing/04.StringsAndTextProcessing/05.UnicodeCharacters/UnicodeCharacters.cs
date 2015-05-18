using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string inputText = Console.ReadLine();

        UnicodeReplaceText(inputText);
    }

    static void UnicodeReplaceText(string inputText)
    {
        foreach (char letter in inputText)
        {
            Console.Write(@"\u{0}", ((int)letter).ToString("X4"));
        }

    }
}