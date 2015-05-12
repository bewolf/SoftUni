using System;
using System.Collections.Generic;
using System.Linq;

class ExtractURLsFromList
{
    static void Main()
    {
        Console.WriteLine("Write some text with URLs: ");
        string text = Console.ReadLine();
        string[] word = text.Split().ToArray();
        string urlStartOne = "http://";
        string urlStartTwo = "www.";
        List<string> URLs = new List<string>();

        //check if any of words contains http:// or www.
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i].Contains(urlStartOne) || word[i].Contains(urlStartTwo))
            {
                URLs.Add(word[i]);
            }
        }
        Console.WriteLine();
        //check if last symbol is dot '.'
        for (int i = 0; i < URLs.Count; i++)
        {

            URLs[i] = URLs[i].TrimEnd('.');
            Console.WriteLine(URLs[i]);
        }
    }
}