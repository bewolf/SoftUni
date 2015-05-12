using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    static void Main()
    {
        Console.WriteLine("Enter letters: ");
        string stringLetters = Console.ReadLine();
        List<string> letters = stringLetters.Split(' ').ToList();
        letters.Sort();
        int counter = 0;
        //for (int i = 1; i < letters.Count; i++)
        //{
        //    if (letters[i - 1] == letters[i])
        //    {
        //        counter++;

        //    }

        //}
        var count = letters.Distinct().Count(counter);
        foreach (var letter in letters)
        {
            Console.WriteLine("{0} -> ", letter);
        }
    }
}