using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string keyword = Console.ReadLine();
        string inputText = Console.ReadLine();

        MatchCollection sentences = Regex.Matches(inputText, @"(\b.*?\b" + keyword + @"\b.*?[.?!])");

        foreach (var sentence in sentences)
        {
            Console.WriteLine(sentence);
        }
    }
}