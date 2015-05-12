using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter score between 1 and 9: ");
        int score = int.Parse(Console.ReadLine());
        if (score <= 0 || score > 9)
        {
            Console.WriteLine("Invalid score");
        }
        else if (score >= 1 && score <= 3)
        {
            Console.WriteLine("Result is {0}", score * 10);
        }
        else if (score >= 4 && score <= 6)
        {
            Console.WriteLine("Result is {0}", score * 100);
        }
        else if (score >= 7 && score <= 9)
        {
            Console.WriteLine("Result is {0}", score * 1000);
        }
    }
}