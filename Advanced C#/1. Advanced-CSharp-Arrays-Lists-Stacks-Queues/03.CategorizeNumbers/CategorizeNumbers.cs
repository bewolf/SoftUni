using System;
using System.Collections.Generic;
using System.Linq;

internal class CategorizeNumbers
{
    private static void Main()
    {
        Console.WriteLine("Enter numbers: ");
        string input = Console.ReadLine();
        double[] numbers = input.Split().Select(double.Parse).ToArray();
        List<double> roundNumbers = new List<double>();
        List<double> nonRoundedNumbers = new List<double>();
        for (int i = 0; i < numbers.Length; i++)
        {
            int rnum = (int)numbers[i];
            if (rnum == numbers[i])
            {
                roundNumbers.Add(numbers[i]);
            }
            else
            {
                nonRoundedNumbers.Add(numbers[i]);
            }
        }
        string roundedNumbers = String.Join(", ",roundNumbers);
        string nonRoundNumbers = String.Join(", ",nonRoundedNumbers);

        
        Console.WriteLine("\n[{4}] -> min: {0}, max: {1}, sum: {2}, avg: {3}", nonRoundedNumbers.Min(), nonRoundedNumbers.Max(), nonRoundedNumbers.Sum(), nonRoundedNumbers.Average(),nonRoundNumbers);
        Console.WriteLine("\n[{4}] -> min: {0}, max: {1}, sum: {2}, avg: {3}", roundNumbers.Min(), roundNumbers.Max(), roundNumbers.Sum(), roundNumbers.Average(), roundedNumbers); 
    }
}