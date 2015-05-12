using System;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter {0} more numbers: ", n-i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        Console.WriteLine();
        foreach (int number in numbers)
        {
            Console.Write("{0} ",number);
        }
    }
}
