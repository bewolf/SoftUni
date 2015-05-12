using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = new int();
        int? min = new int();
        int max = new int();
        double average = new double();
        int numb;
        for (int i = 1; i <= n; i++)
        {
            numb = int.Parse(Console.ReadLine());
            sum += numb;
            if (i == 1)
            {
                min = numb;
                max = numb;
            }
            if (numb > max)
            {
                max = numb;
            }
            if (numb < min)
            {
                min = numb;
            }
        }
        average = (double)sum / (double)n;
        Console.WriteLine("Sum = {0}\nAverage = {1:0.00}\nMin = {2}\nMax = {3}",sum, average, min, max);
    }
}       