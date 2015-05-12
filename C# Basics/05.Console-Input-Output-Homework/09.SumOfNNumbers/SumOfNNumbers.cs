using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter number n: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter new {0} numbers: ", (n+1)-i);
            double newNumb = double.Parse(Console.ReadLine());
            sum = sum + newNumb;
        }
        Console.WriteLine(sum);

    }
}