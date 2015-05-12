using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 1; i <= n; i++)
        {
           numbers[i] = int.Parse(Console.ReadLine());

        }
        Console.WriteLine(numbers);
    }
}