using System;
using System.Linq;

class SortArrayOfNumbers
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        int[] arrNumbers = numbers.Split().Select(int.Parse).ToArray();
        Array.Sort(arrNumbers);
        foreach (var arrNumber in arrNumbers)
        {
            Console.Write("{0} ",arrNumber);
        }
        Console.WriteLine();
    }
}