using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        Console.WriteLine("Enter first pack of numbers numbers: ");
        string firstString = Console.ReadLine();
        Console.WriteLine("Enter second pack of numbers: ");
        string secondString = Console.ReadLine();
        List<string> firstNumbers = firstString.Split(' ').ToList();
        List<string> secondNumbers = secondString.Split(' ').ToList();
        firstNumbers.Select(int.Parse).ToList();
        secondNumbers.Select(int.Parse).ToList();
        firstNumbers.Sort();
        secondNumbers.Sort();
        firstNumbers.AddRange(secondNumbers);
        List<string> result = firstNumbers.Distinct().ToList();
        result.Sort();
        Console.WriteLine();
        foreach (var numbs in result)
        {
            Console.Write("{0} ", numbs);
        }
        Console.WriteLine();

    }
}