using System;
using System.Text.RegularExpressions;

    class SumOf5Numbers
    {
        static void Main()
        {
            Console.Write("Enter 5 numbers in single lane: ");
            string input = Console.ReadLine();
            string[] numbers = Regex.Split(input, @"\D+");
            int sum = 0;
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    int i = int.Parse(value);
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
