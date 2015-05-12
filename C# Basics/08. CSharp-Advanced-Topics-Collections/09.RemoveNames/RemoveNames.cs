using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        Console.WriteLine("Enter first names: ");
        string firstNames = Console.ReadLine();
        List<string> firstNamesList = firstNames.Split().ToList();

        Console.WriteLine("Enter second names: ");
        string secondNames = Console.ReadLine();
        List<string> secondNamesList = secondNames.Split().ToList();

        firstNamesList.RemoveAll(item => secondNamesList.Contains(item));
        Console.WriteLine();
        foreach (string name in firstNamesList)
        {
            Console.Write("{0} ", name);
        }
    }
}