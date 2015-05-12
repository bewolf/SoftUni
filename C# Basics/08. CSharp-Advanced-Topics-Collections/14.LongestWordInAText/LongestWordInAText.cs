using System;
using System.Linq;

class LongestWordInAText
{
    static void Main()
    {
        Console.WriteLine("Enter some text: ");
        string theText = Console.ReadLine();
        string[] word = theText.Split(' ').ToArray();
        string longestWord = word[0];

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i].Length > longestWord.Length)
            {
                longestWord = word[i];
            }
        }
        longestWord = longestWord.TrimEnd('.'); // remove is last is '.'
        Console.WriteLine(longestWord);
    }
}