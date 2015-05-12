using System;
using System.Text.RegularExpressions;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstSum = 0;
        int secondSum = 0;
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            string[] numbers = Regex.Split(input, @"\D+");

            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    int u = int.Parse(value);
                    firstSum = firstSum + u;
                }
            }

        }
        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum = {0}",firstSum);
        }
        else
        {
            Console.WriteLine("No, diff = {0}", firstSum - secondSum);
        }
    }
}