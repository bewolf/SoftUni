using System;

class WorkHours
{
    static void Main()
    {
        Console.WriteLine();
        double h = double.Parse(Console.ReadLine());
        Console.WriteLine();
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine();
        double p = double.Parse(Console.ReadLine());
        if ((h < 0 || h > 2147483647) || (d <0 || d > 89478485) || (p <0 || p> 100))
        {
            Console.WriteLine("Enter correct numbers!");
        }
        else
        {
            d = d - (d * 10) / 100;
            d = d * 12;
            p = p / 100;
            d = d * p;
            double workHours = h - d;
            if (workHours > 0)
            {
                Console.WriteLine("No");
                Console.WriteLine((int)d - h);
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine((int)d - h);
            }
        }

    }
}